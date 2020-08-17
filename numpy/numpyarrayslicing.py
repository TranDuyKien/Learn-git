import numpy as np
# arrslicing= np.array([[[1,2,3],[4,5,6]],[[7,8,9],[10,11,12]]])
arrslicing = np.array([1,2,3,4,5,6,7,8,9])
print(arrslicing)
#Lấy ra các phần tử thông qua chỉ số phần tử từ 1 đến 5
print(arrslicing[1:5])
#Lấy ra các phần tử từ index được chỉ định đến cuối mảng
print(arrslicing[4:])
#Lấy ra các phần tử từ đầu mảng đến phần tử trước phần tử được chỉ định
print(arrslicing[:4])
#Slice from the index 3 from the end to index 1 from the end:
print(arrslicing[-3:-1:])
#Return every other element from index 1 to index 5:
print(arrslicing[1:5:2])
#Trả về các phần tử tính từ đầu mảng với bước nhảy index đã được chỉ định
print(arrslicing[::3])


arr = np.array([[1, 2, 3, 4, 5], [6, 7, 8, 9, 10]])

#Lấy ra các phần tử thứ 2 nằm trong hai mảng
print(arr[1, 1:4])
print(arr[0:2, 2])
#Lây ra các phần tử từ index 1 đến index3 trong hai mảng
print(arr[0:2, 1:4])

