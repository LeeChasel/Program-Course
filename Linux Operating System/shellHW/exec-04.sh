#!bin/bash
read -p "Check the ip is legal or not: " ip
if [ $( echo $ip | grep -E '^((25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$' | grep -o "\." | wc -l) -eq 3 ];
then
    echo "Is legal."
else 
    echo "Is illegal."
fi

# https://zh.wikipedia.org/zh-tw/%E6%AD%A3%E5%88%99%E8%A1%A8%E8%BE%BE%E5%BC%8F
# https://blog.haostudio.net/hwp/shell-tips-ipv4-address-%E5%88%A4%E6%96%B7/
# https://superuser.com/questions/202818/what-regular-expression-can-i-use-to-match-an-ip-address