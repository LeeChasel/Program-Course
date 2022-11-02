#!bin/bash
echo "Generate 3 numbers:"
a=$((RANDOM%101*2))
b=$((RANDOM%101*2))
c=$((RANDOM%101*2))
echo "$a $b $c"
max=$a
if [  $b > $max ]
then
	max=$b
fi
if [ $c > $max ]
then
	max=$c
fi
echo "The maximum number is $max"
