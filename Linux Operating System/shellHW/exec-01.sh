#!/bin/bash
read -p "How tall are you? (cm) : " height
read -p "How much do you weight? (kg) : " weight
echo "----------Result----------"
height=$height/100
bmi=$(echo "scale=2;$weight/($height*$height)" | bc)
echo "Your BMI is $bmi"
