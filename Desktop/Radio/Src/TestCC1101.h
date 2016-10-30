#include "CC1101.h"
#define TEST_MODE SEND_MODE
//#define TEST_MODE RECEIVE_MODE


#if TEST_MODE == SEND_MODE

unsigned char x[3] = {9,8,7};
int main(){
	
	CC1101Setup();
	TogglePin(LED3_PORT,LED3_PIN);//setup success

	
	while(true){
		
		/*
		 * if send data success
		 */
		if(Read(BUTTON_PORT,BUTTON_PIN)){
			while(Read(BUTTON_PORT,BUTTON_PIN));
			TogglePin(LED1_PORT,LED1_PIN);
			CC1101SendData(x,3);
			Delay(1000);
		}
	}
}

#elif TEST_MODE == RECEIVE_MODE
/* cc1101 receive data ***/

unsigned char x[3] = {0,0,0};
int main(){
	CC1101Setup();
	TogglePin(LED2_PORT,LED2_PIN);
	CC1101SetReceive();
	//unsigned char dataReceive[1];
	
	while(true){
		
		/*
		 * Check if have data sending
		 */
		if(CheckReceiveFlag()){
			while(CheckReceiveFlag());
			CC1101ReceiveData(x);
			
			/*
			 * If read data success
			 */
			if((*x == 9) && (*(x + 1) == 8) && (*(x + 2) == 7))
				for(int i = 0; i < 20 ; i ++){
					TogglePin(LED1_PORT,LED1_PIN);
					Delay(150);
					
					/*
					 * Must set flag receive after received data
					 */
					CC1101SetReceive();
				}
		}
	}
	
}
#endif
