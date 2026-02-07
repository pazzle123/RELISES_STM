/*
 * rtos.h
 *
 *  Created on: Jan 17, 2026
 *      Author: yaros
 */

#ifndef INC_RTOS_H_
#define INC_RTOS_H_
#include <stdint.h>

void Serial_Transmit(uint8_t* data,uint8_t size);
void Write_Mem(uint8_t addDev,uint8_t addMem,uint8_t *data,uint8_t size);
void Read_Mem(uint8_t addDev,uint8_t addMem,uint8_t *data,uint8_t size);
void Oled_on(void);
#endif /* INC_RTOS_H_ */
