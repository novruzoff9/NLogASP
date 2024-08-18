## NLog Project

Proyekt [Nlog-un rəsmi dokumentesasiyası](https://github.com/NLog/NLog/wiki/Getting-started-with-ASP.NET-Core-6) əsasında hazırlanmışdır.

#### 1. Addım (Yükləmə)

İlk öncə Nuget-lardan `Nlog` və `NLog.Web.AspNetCore` paketləri yüklənir.

#### 2. Addım (Konfiqurasiya)

Daha sonra `nlog.config` faylı yaradılaraq içi doldurulur.

#### 2. Addım (Uyğunlaşdırma)

Daha sonra `Program.cs` faylı NLog-a uyğunlaşdırılır.

#### 4. Addım (İstifadə)

Home Controller-un Index action-da aşağıdakı sətirlə NLog-u stifadə etməyə başlayırıq.
`Logger logger = LogManager.GetCurrentClassLogger();`
Sonrasında isə kodumuzun hər hansı bir hissəsində təhlükə səviyyəsinə görə logger-i işə salırıq.

```
logger.Trace("Trace səviyyəsi üçün log");
logger.Info("Informasiya səviyyəsi üçün log");
logger.Debug("Debug səviyyəsi üçün log");
logger.Warn("Xəbərdarlıq səviyyəsi üçün log");
logger.Error("Xəta səviyyəsi üçün log");
logger.Fatal("Çökmə səviyyəsi üçün log");
```

Logların necə qeyd ediləcəyini seçmək üçün isə öncədən yaratdığımız `nlog.config` faylından istifadə edirik.

```
<targets>
	<target xsi:type="Console" name="WriteToConsole" layout="${longdate} ${level} ${message}"/>

	<target xsi:type="File" name="WriteToFile" fileName="${basedir}/logs/${shortdate}.log" layout="${longdate} ${level} ${message}"/>
</targets>
```
targets hissəsindən istifadə edərək loglamanın harada yerinə yetirələcəyini qeyd edirik. Bu əsasən ya fayl ya da konsol üzərindən olur.

```
<rules>
	<logger name="*" minlevel="Trace" writeTo="WriteToFile" />
	<logger name="*" minlevel="Trace" writeTo="WriteToConsole" />
</rules>
```
sonda isə rules hissəsində olanların name atributlarına əsasən logger-lər yazırıq və proqramı işə salırıq."# NLogASP" 
