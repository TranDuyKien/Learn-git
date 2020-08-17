#TẠO RA MỘT FILE
# f = open("handlingfilepython/myfile.txt","x")
# f.close()

#VIẾT VÀO MỘT FILE
# f = open("handlingfilepython/myfile.txt","w")
# f.write("Created and written successful \nContinuous")

#ĐỌC FILE
# f = open("handlingfilepython/myfile.txt","r")
# print(f.read())
# f.close()


#TẠO VÀ VIẾT MỘT FILE MỚI NẾU NÓ ĐÃ TỒN TẠI
# f= open("handlingfilepython/newfile.txt","w")
# f.close()


#XÓA MỘT FILE ĐÃ TỒN TẠI
# import os
# if os.path.exists("handlingfilepython/newfile.txt"):
#     os.remove("handlingfilepython/newfile.txt")
# else:
#     print("Đường dẫn file không tồn tại")


#TẠO MỘT THƯ MỤC
# f = open("handlingfilepython/new","x")
# f.close()


#XÓA THƯ MỤC
# import os
# if os.path.exists("handlingfilepython/new"):
#     os.rmdir("handlingfilepython/new")
# else:
#     print("đường dẫn không tồn tại")

