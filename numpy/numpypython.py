import numpy as np
print(np.__version__)
#TẠO RA MỘT numpy array
# a =  np.array([1,2,3])
# #KIỂM TRA KIỂU DỮ LIỆU CỦA a
# print(type(a))
# print(a.shape)
# #Lấy ra value theo chỉ số phần tử
# print(a[0],a[1],a[2])
# a[0] = "6"
# print(a)
b = np.array([[1,2,3],[4,5,6]])
print(b.shape)
print(b[0][0],b[0][1],b[1][0])

# print(np.random.random((shape = (2, 3))))
