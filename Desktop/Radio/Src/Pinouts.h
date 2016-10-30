/*
 * PinOut.h
 *
 *  Created on: 09-09-2016
 *      Author: toan
 */
#ifndef PINOUT_H_
#define PINOUT_H_
//*************************************** pins **************************************************//
/*
 * define pin
 * set in put,out put direction for each pin
 */
 
 /*define led for test */
#define LED1_PORT GPIOD
#define LED1_PIN GPIO_PIN_12

#define LED2_PORT GPIOD
#define LED2_PIN GPIO_PIN_13

#define LED3_PORT GPIOD
#define LED3_PIN GPIO_PIN_14

#define LED4_PORT GPIOD
#define LED4_PIN GPIO_PIN_15

/* define button */
#define BUTTON_PORT GPIOA
#define BUTTON_PIN GPIO_PIN_0


#define SCK_PIN GPIO_PIN_5 // port A
#define SCK_PORT GPIOA

#define MISO_PIN GPIO_PIN_6 // port A
#define MISO_PORT GPIOA

#define MOSI_PIN GPIO_PIN_7 // port A
#define MOSI_PORT GPIOA

#define SS_PIN GPIO_PIN_0 // port B
#define SS_PORT GPIOB

#define GDO0_PIN GPIO_PIN_1 // port B
#define GDO0_PORT GPIOB


#define GDO2_PIN GPIO_PIN_2 // port B
#define GDO2_PORT GPIOB

#endif /* PINOUT_H_ */
