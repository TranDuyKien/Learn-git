import numpy as np

arr  = np.array([[[1,2,3],[4,5,6]],[[7,8,9],[10,11,12]]])
for x in arr.reshape(-1):
    print(x)


arriter = np.array([[[1, 2], [3, 4]], [[5, 6], [7, 8]]])
for x in np.nditer(arriter):
    print(x)