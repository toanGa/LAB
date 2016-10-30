#include "CC1101.h"

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

