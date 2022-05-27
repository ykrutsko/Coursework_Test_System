Application "Testing system"	(05.2022)
------------------------------------------------------------ 
Network system for taking tests, such as students or pupils.
The application is implemented using .Net technology (Windows Forms). Data warehouse - MS SQL SERVER. The Entity Framework and the Repository pattern are used to access the data. Network communication is carried out using the TCP protocol. Asynchronous programming.

The application consists of three programs:
1. Test designer
2. Server
3. Client

Importantly!
------------------------------------------------------------ 
1. For start server You must have installed MS SQL
2. The database files will be generated in the folder where the file "TestServer.exe" is located
3. Running two servers on the same host at the same time is blocked (global mutex is used)
4. Port 5000 must be open for network communication

The database contains the initial datas:
------------------------------------------------------------ 
	Users:
		Log:  Admin
		Pass: admin
		Super administator (cannot be deleted)
		
		Log:  Student
		Pass: 123
		
	Groups:
		Administrators (one only possible group of administrators, cannot be deleted)
			member: Admin
			
		Students
			member: Student

------------------------------------------------------------ 			
With best regards, Yurii Krutsko	

LinkedIn: https://www.linkedin.com/in/yurii-krutsko/
GitHub:   https://github.com/ykrutsko

			