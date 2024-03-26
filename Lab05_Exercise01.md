# Lab 5 Exercise 1

## การสร้าง Class


1. สร้าง console application project

```
dotnet new console --name Lab05_Ex01
```
2. เปลี่ยน code ให้เป็นดังต่อไปนี้

```cs
Person p = new Person();
System.Console.WriteLine($"Type of p is {p.GetType()}");

class Person
{

}
```

3. Build project โดยการใช้คำสั่ง

```
dotnet build  Lab05_Ex01
```

4. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
   ![image](https://github.com/ThanchiraCharakhon099/03376836-OOP-2566-Lab-05/assets/144195708/dfb41234-343d-4964-98a5-fc7e6a437177)


5. Run project โดยการใช้คำสั่ง

```
dotnet run --project Lab05_Ex01
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/ThanchiraCharakhon099/03376836-OOP-2566-Lab-05/assets/144195708/5ff0c795-82cc-4bf1-8020-6868e56942f7)


7. อธิบายสิ่งที่พบในการทดลอง
   การทดลองนี้เป็นการสร้างและใช้งาน object ของ class Person ใน C# 


