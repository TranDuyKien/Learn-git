class Bank:
    def getresult(self):
        return 10
class MSB(Bank):
    def getresult(self):
        return 4
class SHB(Bank):
    def getresult(self):
        return 5
B = Bank()
M = MSB()
S = SHB()
print("The result",B.getresult())
print("The result",M.getresult())
print("The result",S.getresult())