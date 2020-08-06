import numpy as np
#shape trả về kích thước của mảng bao gồm số row và số colum (loại matrix)
#CHÚ Ý: shape chỉ trả ra giá trị nếu matrix không phải là matrix răng cưa
# arr = np.array([[1,2],[3,4],[5,6]])
# print(arr.shape)


#số chiều tối thiểu khi return object, nên đặt = 2 để tiện cho việc indexing ma trận cho Machine Learning.
# arrndmin= np.array([1,2,3,5],ndmin=5)
# print(arrndmin)
# print(arrndmin.shape)


#Convert mảng một chiều thành matrix có số phần tử tương ứng
# arrreshape = np.array([1,2,3,4,5,6,7,8,9,10,11,12])
# a=arrreshape.reshape(3,4)
# print(a)
# print(a.base)

#Trả về mảng một chiều
# arrone= np.array([[[1,2,3,4],[5,6,7,8],[9,10,11,12]],[1,2,3]])
# print(arrone)
# print(arrone.reshape(2,-1).reshape(-1))



#Trả về hàm một chiều 
arr = np.array([[1, 2, 3], [4, 5, 6]])

# a= arr.reshape(-1)
for x in arr:
    for y in x:
        print(y)



