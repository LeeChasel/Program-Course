#!/bin/bash

read -p "Start date:" start
read -p "End date:" end

start_s=`date -d "$start" +%s`
end_s=`date -d "$end" +%s`
days=$((($end_s - $start_s) / 86400))
echo "$days days"