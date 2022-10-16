#!bin/bash

printf  "Please select a format of date:\n1) Canada\n2) Denmark\n3) Finland\n4) French\n5) Germany\n6) Italy\n7) United States\n"
read -p "Which one do you want? >> " format
case $format in
	"1")
		date "+%d/%m/%y"
		;;
	"2")
		date "+%Y-%m-%d"
		;;
	"3")
		date "+%d.%m.%Y"
		;;
	"4")
		date "+%d/%m/%Y"
		;;
	"5")
		date "+%Y-%m-%d"
		;;
	"6")
		date "+%d/%m/%y"
		;;
	"7")
		date "+%m-%d-%y"
		;;
esac
