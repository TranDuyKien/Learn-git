from random import randint
computer_chose = randint(0,2)
if computer_chose == 0:
    computer_chose= "Keo"
elif computer_chose == 1:
    computer_chose ="Bua"
else:
    computer_chose="La"

print("Nhập vào lựa chọn Keo, Bua, La")
my_chose = input()

print("You chose: "+my_chose)
print("Computer chose: "+computer_chose)


if my_chose == computer_chose:
    print("Nobody win")

else:
    if my_chose=="Keo":
        if computer_chose=="Bua":
            print("You lose")
        else:
            print("You win")

    elif my_chose=="Bua":
        if computer_chose=="Keo":
            print("You win")
        else:
            print("You lose")

    elif  my_chose=="La":
        if computer_chose =="Bua":
            print("You win")
        else:
            print("You lose")
    else:
        print("Nhập sai - nhập lại!")
