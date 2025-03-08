using FactoryPattern.LogConcretes;

var elkLog = new LogFactory().GetLogger("ELK");
var fileLog = new LogFactory().GetLogger("File");
var dbLog = new LogFactory().GetLogger("DB");

elkLog.Log("ELK Deneme");
fileLog.Log("file Deneme");
dbLog.Log("db Deneme");