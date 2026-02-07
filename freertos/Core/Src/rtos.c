/*
 * rtos.c
 *
 *  Created on: Jan 17, 2026
 *      Author: yaros
 */

#include "rtos.h"
#include "main.h"
#include <stdint.h>

extern I2C_HandleTypeDef hi2c1;
extern SPI_HandleTypeDef hspi2;
extern  UART_HandleTypeDef huart2;


void Serial_Transmit(uint8_t* data,uint8_t size){
	HAL_UART_Transmit(&huart2, data, size, 100);
}

void Write_Mem(uint8_t addDev,uint8_t addMem,uint8_t *data,uint8_t size){
	uint8_t buff[1+256];
	buff[0] = addMem;
	memcpy(&buff[1],data,size);
	HAL_I2C_Master_Transmit(&hi2c1, addDev, buff, 1+size, 100);
}

void Read_Mem(uint8_t addDev,uint8_t addMem,uint8_t *data,uint8_t size){
	HAL_I2C_Mem_Read(&hi2c1, addDev, addMem, I2C_MEMADD_SIZE_8BIT, data, size, 100);
}

void Oled_on(void)
{

    HAL_GPIO_WritePin(GPIOA, GPIO_PIN_8, GPIO_PIN_RESET);  // RES = 0
    HAL_Delay(10);
    HAL_GPIO_WritePin(GPIOA, GPIO_PIN_8, GPIO_PIN_SET);    // RES = 1
    HAL_Delay(10);


    HAL_GPIO_WritePin(GPIOA, GPIO_PIN_9, GPIO_PIN_RESET);  // DC = 0 → команда
    HAL_GPIO_WritePin(GPIOA, GPIO_PIN_10, GPIO_PIN_RESET); // CS = 0 → активировать


    uint8_t cmd = 0xAF;
    HAL_SPI_Transmit(&hspi2, &cmd, 1, HAL_MAX_DELAY);


    HAL_GPIO_WritePin(GPIOA, GPIO_PIN_10, GPIO_PIN_SET);   // CS = 1 → деактивировать
}



