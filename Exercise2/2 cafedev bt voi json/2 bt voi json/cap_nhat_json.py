# -----------------------------------------------------------
#Cafedev.vn - Kênh thông tin IT hàng đầu Việt Nam
#@author cafedevn
#Contact: cafedevn@gmail.com
#Fanpage: https://www.facebook.com/cafedevn
#Group: https://www.facebook.com/groups/cafedev.vn/
#Instagram: https://instagram.com/cafedevn
#Twitter: https://twitter.com/CafedeVn
#Linkedin: https://www.linkedin.com/in/cafe-dev-407054199/
#Pinterest: https://www.pinterest.com/cafedevvn/
#YouTube: https://www.youtube.com/channel/UCE7zpY_SlHGEgo67pHxqIoA/
# -----------------------------------------------------------

import json

data_file = open("du_lieu/khach_hang.json", encoding="utf-8")
noi_dung = json.load(data_file) # Load noi dung file len

# Thong tin bo sung
bo_sung = {
    "Dia chi" : "Nguyen chi thanh",
    "So DT" : "01222145789654"
}

# Cap nhat la data
noi_dung.update(bo_sung)

# Ghi de noi dung moi len noi dung cu
data_file = open("du_lieu/khach_hang.json", "w")
json.dump(noi_dung, data_file, indent=4)
data_file.close()
