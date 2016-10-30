// dinh nghia lai SPISendChar,SPIReceiverChar
#include "stm32f4xx_hal.h"

#define CSn_High() HAL_GPIO_WritePin(GPIOB, GPIO_PIN_0, GPIO_PIN_SET)
#define CSn_Low() HAL_GPIO_WritePin(GPIOB, GPIO_PIN_0, GPIO_PIN_RESET)
#define Write(port,pin,level) HAL_GPIO_WritePin(port, pin, level)
#define Read(port,pin) HAL_GPIO_ReadPin(port,pin)
#define Delay(x) HAL_Delay(x)
#define TogglePin(port,pin) HAL_GPIO_TogglePin(port,pin)

#define LOW GPIO_PIN_RESET
#define HIGH GPIO_PIN_SET


/******************* spi globle var********************************** 
 ********************************************************************/
unsigned char dataSend = 0;
unsigned char dataReceive = 0;
 /*********************************************************************/
 
typedef enum{
	false,
	true
}bool;

void SPISendChar(unsigned char data){
	HAL_SPI_Transmit(&hspi1,&data,1,10);
}

unsigned char SPIReceiveChar(){
	return dataReceive;
}