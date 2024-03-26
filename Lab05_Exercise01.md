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

4. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-05/assets/144195611/5d766a78-d557-4e62-b383-a3902645ac32)


5. Run project โดยการใช้คำสั่ง

```
dotnet run --project Lab05_Ex01
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-05/assets/144195611/f7565789-55db-4b63-b443-edebb0a5617a)

7. อธิบายสิ่งที่พบในการทดลอง
- เป็นการสร้าง object โดยใช้method GetType() คือการแสดงประเภทของวัตถุ
