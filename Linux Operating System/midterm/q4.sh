#!/bin/bash

echo "Please enter a string and this validator will check it is a valid email or not."
read -p ">" email

if [[ "$email" =~ ^[a-zA-Z]{1}.{7,}@.{1,}\.com$ ]]
then
    echo "It's a valid email address."
else
    echo "It's an invalid email address."
fi