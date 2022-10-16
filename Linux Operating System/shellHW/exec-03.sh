#!bin/bash
read -p "Start date: " start
read -p "End date: " end
start_s=$(date +%s -d "$start")
end_s=$(date +%s -d "$end")
days=$((($end_s-$start_s)/86400))
echo "$days days"
