#!/bin/bash

read -p "Please set a directory:" directory
while [[ "$directory" =~ [~] ]]
do
    echo "Can not contain '~', try again."
    read -p "Please set a directory:" directory
done

read -p "Please set a file list location:" location
while [[ "$location" =~ [~] ]]
do
    echo "Can not contain '~', try again."
    read -p "Please set a file list location:" location
done

if [ "$location" == "" ]
then
    location="$HOME"
fi

ls -al "$directory" > "$location"/list.txt
echo "File list is generate to $location/list.txt"