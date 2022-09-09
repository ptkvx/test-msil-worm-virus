using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Serialization;

namespace SmartAssembly.SmartExceptionsCore;

[WebServiceBinding(Name = "ReportingServiceSoap", Namespace = "http://www.smartassembly.com/webservices/Reporting/")]
internal class ReportingService : SoapHttpClientProtocol
{
	public ReportingService(string serverURL)
	{
		((WebClientProtocol)this).set_Url(serverURL + "Reporting.asmx");
		((WebClientProtocol)this).set_Timeout(180000);
	}

	[SoapDocumentMethod("http://www.smartassembly.com/webservices/Reporting/UploadReport")]
	public string UploadReport(string licenseID, [XmlElement(DataType = "base64Binary")] byte[] data, string email)
	{
		return (string)((SoapHttpClientProtocol)this).Invoke("UploadReport", new object[3] { licenseID, data, email })[0];
	}
}
