#!bin/bash
read -p "Please enter a string and this validator will check it is a valid email address or not: " email
regex=^[a-zA-Z]+[a-zA-Z0-9]{7,}+@+[a-zA-Z0-9.]+\.com$
if [[ $email =~ $regex ]]
then
	echo "It's a valid email address."
else 
	echo "It's a invalid email address."
fi
