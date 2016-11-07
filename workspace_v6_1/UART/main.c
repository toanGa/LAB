#include <msp430.h> 
#include "UART.h"

/*
 * main.c
 */
int main(void) {
////////////////////////////
    WDTCTL = WDTPW | WDTHOLD;	// Stop watchdog timer
    DCOCTL = 0;
    BCSCTL1 = CALBC1_1MHZ;
    DCOCTL = CALDCO_1MHZ;

	UART_Init();
///////////////////////////////

	unsigned long x = 1;
	while(1){
		UART_Write_Int(x);
		x ++;
		_delay_cycles(1000);
	}



}
