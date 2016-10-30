#include "SystemConfig.h"
#include "Pinouts.h"
#include "Register.h"


/****************************************************************/
#define 	WRITE_BURST     	0x40						//write burst
#define 	READ_SINGLE     	0x80						//read single
#define 	READ_BURST      	0xC0						//read burst
#define 	BYTES_IN_RXFIFO     0x7F  						//byte number in RXfifo

/****************************************************************/
unsigned char PaTabel[8] = {0x60 ,0x60 ,0x60 ,0x60 ,0x60 ,0x60 ,0x60 ,0x60};
/*
 * Declear function
 */
void CC1101Setup();
//void GDOSet();
void Reset();
void SPIWriteReg(unsigned char addr, unsigned char value);
void SPIWriteBurstReg(unsigned char addr, unsigned char *buffer, unsigned char num);
void SPIStrobe(unsigned char strobe);
unsigned char SPIReadReg(unsigned char addr);
void SPIReadBurstReg(unsigned char addr, unsigned char *buffer, unsigned char num);
unsigned char SPIReadStatus(unsigned char addr);
void RegConfigSetting();
void CC1101SendData(unsigned char *txBuffer,unsigned char size);
void CC1101SetReceive();
bool CheckReceiveFlag();
unsigned char CC1101ReceiveData(unsigned char *rxBuffer);

/*
 * Spec func
 */

void CC1101Setup(){
	//GDOSet();
	//setup io and spi
	SystemConfig();
	
	CSn_High();
	Write(SCK_PORT,SCK_PIN,HIGH);
	Write(MOSI_PORT,MOSI_PIN,LOW);
	Reset();
	RegConfigSetting();
	
	/*** PATABLE config ****/
	SPIWriteBurstReg(CC1101_PATABLE,PaTabel,8);
	//CSn_Low();
}

void Reset(){
	Write(SS_PORT,SS_PIN,LOW);
	Delay(1);
	Write(SS_PORT,SS_PIN,HIGH);
	Delay(1);
	Write(SS_PORT,SS_PIN,LOW);
	
	while(Read(MISO_PORT,MISO_PIN));
	SPISendChar(CC1101_SRES);
	
	while(Read(MISO_PORT,MISO_PIN));
	Write(SS_PORT,SS_PIN,HIGH);
	
}

void SPIWriteReg(unsigned char addr, unsigned char value){
	CSn_Low();
	
	/*** arduino co lenh nay ***/
	while(Read(MISO_PORT,MISO_PIN));
	
	SPISendChar(addr);
	SPISendChar(value);
	CSn_High();
}

void SPIWriteBurstReg(unsigned char addr, unsigned char *buffer, unsigned char num){
	unsigned char i,temp;
	temp = addr|WRITE_BURST;
	CSn_Low();
	
	/** arduino co lenh nay
	 ** 
			while(Read(MISO_PORT,MISO_PIN));
	****/
	SPISendChar(temp);
	
	for(i = 0; i < num ; i++){
		SPISendChar(buffer[i]);
	}
	CSn_High();
}
//////////////////////////////
void SPIStrobe(unsigned char strobe){
	CSn_Low();
	while(Read(MISO_PORT,MISO_PIN));
	SPISendChar(strobe);
	
	/*
		msp co them lenh
		Doi den khi truyen xong
	 */
	CSn_High();
}

/////////////////////////////
// xem lai cho sau khi truyen [0] xong
//doi den khi co tin hieu phan hoi
unsigned char SPIReadReg(unsigned char addr){
	unsigned char temp, value;
		temp = addr|READ_SINGLE;

		Write(SS_PORT,SS_PIN,LOW);
	
		//arduino co them lenh read MISO pin
		while(Read(MISO_PORT,MISO_PIN));
		
		SPISendChar(temp);
		//while (!(IFG2&UCB0TXIFG));                // Wait for TXBUF ready
		//UCB0TXBUF = 0;							  // Dummy write so we can read data
		SPISendChar(0);
	  Delay(100);
	//while(UCB0STAT & UCBUSY);					  // Wait for TX to complete
		value = SPIReceiveChar();                           // Read data
		Write(SS_PORT,SS_PIN,HIGH);
		return value;
}

void SPIReadBurstReg(unsigned char addr, unsigned char *buffer, unsigned char num){
	unsigned char i,temp;
	temp = addr|READ_BURST;
	CSn_Low();
	
	while(Read(MISO_PORT,MISO_PIN)){};
	SPISendChar(temp);
	for(i = 0; i < num ; i ++){
		//////////////////////////////
		// trong msp
		//  waite tx buffer ready
		// 
		SPISendChar(0);
		//trong msp
		// waite tx complete
		buffer[i] = SPIReceiveChar();
	}
	CSn_High();
}


// so sanh lai SPITransfer trong arduino
unsigned char SPIReadStatus(unsigned char addr){
	unsigned char status;
	
	CSn_Low();
	while(Read(MISO_PORT,MISO_PIN));
	SPISendChar(addr|READ_BURST);
	SPISendChar(0);
	status = SPIReceiveChar();
	CSn_High();
		
	return status;
}


void RegConfigSetting(){
		SPIWriteReg(CC1101_FSCTRL1,  0x08);
    SPIWriteReg(CC1101_FSCTRL0,  0x00);
    SPIWriteReg(CC1101_FREQ2,    0x10);
    SPIWriteReg(CC1101_FREQ1,    0xA7);
    SPIWriteReg(CC1101_FREQ0,    0x62);
    SPIWriteReg(CC1101_MDMCFG4,  0x5B);
    SPIWriteReg(CC1101_MDMCFG3,  0xF8);
    SPIWriteReg(CC1101_MDMCFG2,  0x03);
    SPIWriteReg(CC1101_MDMCFG1,  0x22);
    SPIWriteReg(CC1101_MDMCFG0,  0xF8);
    SPIWriteReg(CC1101_CHANNR,   0x00);
    SPIWriteReg(CC1101_DEVIATN,  0x47);
    SPIWriteReg(CC1101_FREND1,   0xB6);
    SPIWriteReg(CC1101_FREND0,   0x10);
    SPIWriteReg(CC1101_MCSM0 ,   0x18);
    SPIWriteReg(CC1101_FOCCFG,   0x1D);
    SPIWriteReg(CC1101_BSCFG,    0x1C);
    SPIWriteReg(CC1101_AGCCTRL2, 0xC7);
		SPIWriteReg(CC1101_AGCCTRL1, 0x00);
    SPIWriteReg(CC1101_AGCCTRL0, 0xB2);
    SPIWriteReg(CC1101_FSCAL3,   0xEA);
		SPIWriteReg(CC1101_FSCAL2,   0x2A);
		SPIWriteReg(CC1101_FSCAL1,   0x00);
    SPIWriteReg(CC1101_FSCAL0,   0x11);
    SPIWriteReg(CC1101_FSTEST,   0x59);
    SPIWriteReg(CC1101_TEST2,    0x81);
    SPIWriteReg(CC1101_TEST1,    0x35);
    SPIWriteReg(CC1101_TEST0,    0x09);
    SPIWriteReg(CC1101_IOCFG2,   0x0B); 	//serial clock.synchronous to the data in synchronous serial mode
    SPIWriteReg(CC1101_IOCFG0,   0x06);  	//asserts when sync word has been sent/received, and de-asserts at the end of the packet 
    SPIWriteReg(CC1101_PKTCTRL1, 0x04);		//two status bytes will be appended to the payload of the packet,including RSSI LQI and CRC OK
											//No address check
    SPIWriteReg(CC1101_PKTCTRL0, 0x05);		//whitening off;CRC Enable£»variable length packets, packet length configured by the first byte after sync word
    SPIWriteReg(CC1101_ADDR,     0x00);		//address used for packet filtration.
    SPIWriteReg(CC1101_PKTLEN,   0x3D); 	//61 bytes max length
}

void CC1101SendData(unsigned char *txBuffer,unsigned char size){
	SPIWriteReg(CC1101_TXFIFO,size);
	SPIWriteBurstReg(CC1101_TXFIFO,txBuffer,size);
	SPIStrobe(CC1101_STX);
	while(!Read(GDO0_PORT,GDO0_PIN));
	while(Read(GDO0_PORT,GDO0_PIN));
	SPIStrobe(CC1101_SFRX);
}

void CC1101SetReceive(){
	SPIStrobe(CC1101_SRX);
}

bool CheckReceiveFlag(){
	if(Read(GDO0_PORT,GDO0_PIN)){
		while(Read(GDO0_PORT,GDO0_PIN));
		return true;
	}else
		return false;
}

unsigned char CC1101ReceiveData(unsigned char *rxBuffer){
	unsigned char size;
	unsigned char status[2];
	
	if(SPIReadStatus(CC1101_RXBYTES) & BYTES_IN_RXFIFO){
		size = SPIReadReg(CC1101_RXFIFO);
		SPIReadBurstReg(CC1101_RXFIFO,rxBuffer,size);
		SPIReadBurstReg(CC1101_RXFIFO,status,2);
		SPIStrobe(CC1101_SFRX);
		
		return size;
	}else{
		SPIStrobe(CC1101_SFRX);
		return 0;
	}
}

