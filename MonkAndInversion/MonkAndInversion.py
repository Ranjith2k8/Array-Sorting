t= int(input())
while(t!=0):
    t = t-1
    n = int(input())
    matrix = []
    for i in range(n):
        matrix.append(list(map(int,input().split())))
    count = 0
    for i in range(n):
        for j in range(n):
            for k in range(i,n):
                for l in range(j,n):
                    if(matrix[i][j]>matrix[k][l]):
                        count+=1
    print(count)