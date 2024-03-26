# Lab 5 Exercise 6

## Method with parameter 


1. สร้าง console application project

```
dotnet new console --name Lab05_Ex06
```
2. เปลี่ยน code ให้เป็นดังต่อไปนี้

```cs
var mc = new MyClass();
mc.DisplayParam(3, 4);
class MyClass
{
    public void DisplayParam(int a, int b)
    {
        System.Console.WriteLine($"a = {a}, b = {b}");
    } 
}
```

3. Build project โดยการใช้คำสั่ง

```
dotnet build  Lab05_Ex06
```

4. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![image](https://github.com/ThanchiraCharakhon099/03376836-OOP-2566-Lab-05/assets/144195708/ce66552e-c1b9-4a95-b3f1-6880bfbca1cf)

5. Run project โดยการใช้คำสั่ง

```
dotnet run --project Lab05_Ex06
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/ThanchiraCharakhon099/03376836-OOP-2566-Lab-05/assets/144195708/d1d3e78a-bd95-4397-a937-afd50e41f9c3)


7. อธิบายสิ่งที่พบในการทดลอง
โปรแกรมจะแสดงผล a = 3, b = 4 เพราะการกำหนด Method ด้วย parameter จากเรียกใช้ DisplayParam

