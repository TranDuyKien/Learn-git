class student:
    count = 0
    def __init__(self):
        student.count = student.count + 1
st1 = student()
st2 = student()
print("Số lượng đối tượng đã khởi tạo", student.count)