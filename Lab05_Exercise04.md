# Lab 5 Exercise 4

## Fields declaration and initialization


1. สร้าง console application project

```
dotnet new console --name Lab05_Ex04
```
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-05/assets/144197034/dc64cf74-006f-447d-94a2-0db01ead8d43)

2. เปลี่ยน code ให้เป็นดังต่อไปนี้

```cs
var myObj = new MyClass();

System.Console.WriteLine($"Default integer      F1 = {myObj.F1}");  //Implicit fields initialization
System.Console.WriteLine($"Default string       F2 = {myObj.F2}");
System.Console.WriteLine($"Initialized integer  F3 = {myObj.F3}");  //Explicit field initialization
System.Console.WriteLine($"Initialized string   F4 = {myObj.F4}");

class MyClass
{
    public int F1;
    public string F2;
    public int F3 = 100;
    public string F4 = "ASDF";
}
```
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-05/assets/144197034/e581aca1-b005-482c-91ca-7d728b295b86)

3. Build project โดยการใช้คำสั่ง

```
dotnet build  Lab05_Ex04
```

4. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-05/assets/144197034/599f2661-e82d-4cf0-9c19-066c865f37d5)
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-05/assets/144197034/fe8a26ce-58f4-4630-a494-4cec163a5ddc)


6. Run project โดยการใช้คำสั่ง

```
dotnet run --project Lab05_Ex04
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![ภาพ](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-05/assets/144197034/39762aab-e0b4-4079-807e-fecd4b942692)


7. อธิบายสิ่งที่พบในการทดลอง


