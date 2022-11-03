#!/bin/bash

echo "Generate 3 numbers:"
a=$((($RANDOM%101) * 2))
b=$((($RANDOM%101) * 2))
c=$((($RANDOM%101) * 2))

echo $a $b $c
max=$a
if [$b -gt $max]
then
    max=$b
fi

if [$c -gt $max]
then
    max=$c
fi

echo "The maximum is:"
echo $max