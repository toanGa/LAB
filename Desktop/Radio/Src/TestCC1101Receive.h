/*
 * CC1101 Send data
 */


#include "CC1101.h"

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

//#endif
