# delayed service
A dummy .NET service that can take as long (or as little) as you want to start and/or stop. 

you can register the service using

```
sc create longStartupService binpath= C:\-path-to-executable\longStartupService.exe
```
You can change the startup/shutdown delay in the config file by modifying these keys:

```
<add key="startDelay" value="15000"/>
<add key="stopDelay" value="15000"/>
```

Finally, keep in mind that Service Control Manager has a default timeout of 30s. To extend this then you have to add DWORD ServicesPipeTimeout to HKLM\CurrentControlSet\Control with Decimal value 300000
