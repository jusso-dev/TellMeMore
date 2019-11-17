using System;
using Newtonsoft.Json;

namespace TellMeMoreBlazor.Models.urlscanio
{
	public class urlScanIoNewScanResponse
	{
		public string message { get; set; }
		public string uuid { get; set; }
		public string result { get; set; }
		public string api { get; set; }
		public string visibility { get; set; }
		public OptionsScanResponse options { get; set; }
		public string url { get; set; }
	}

	public class OptionsScanResponse
	{
		public string useragent { get; set; }
	}


	/// <summary>
	/// Used as POST data to urlScanIo API end-point
	/// </summary>
	public class urlScanIoRequestObject
	{
		public string url { get; set; }
		[JsonProperty("public")]
		public string _public { get; set; } = "off";
	}

	/// <summary>
	/// Response data from urlScanIo API end-point
	/// </summary>
	/// 

	public class urlScanIo
	{
		public Data data { get; set; }
		public Stats stats { get; set; }
		public Meta meta { get; set; }
		public Task task { get; set; }
		public Page page { get; set; }
		public Lists lists { get; set; }
		public Verdicts verdicts { get; set; }
	}

	public class Data
	{
		public Request[] requests { get; set; }
		public Cooky[] cookies { get; set; }
		public Console[] console { get; set; }
		public Link[] links { get; set; }
		public Timing timing { get; set; }
		public Global[] globals { get; set; }
	}

	public class Timing
	{
		public DateTime beginNavigation { get; set; }
		public DateTime frameStartedLoading { get; set; }
		public DateTime frameNavigated { get; set; }
		public DateTime frameStoppedLoading { get; set; }
		public DateTime domContentEventFired { get; set; }
		public DateTime loadEventFired { get; set; }
	}

	public class Request
	{
		public Request1 request { get; set; }
		public Request3[] requests { get; set; }
		public Response response { get; set; }
		public Initiatorinfo initiatorInfo { get; set; }
	}

	public class Request1
	{
		public string requestId { get; set; }
		public string loaderId { get; set; }
		public string documentURL { get; set; }
		public Request2 request { get; set; }
		public float timestamp { get; set; }
		public float wallTime { get; set; }
		public Initiator initiator { get; set; }
		public Redirectresponse redirectResponse { get; set; }
		public string type { get; set; }
		public string frameId { get; set; }
		public bool hasUserGesture { get; set; }
	}

	public class Request2
	{
		public string url { get; set; }
		public string method { get; set; }
		public Headers headers { get; set; }
		public string mixedContentType { get; set; }
		public string initialPriority { get; set; }
		public string referrerPolicy { get; set; }
	}

	public class Headers
	{
		public string UpgradeInsecureRequests { get; set; }
		public string UserAgent { get; set; }
		public string SecFetchMode { get; set; }
		public string Referer { get; set; }
		public string Origin { get; set; }
	}

	public class Initiator
	{
		public string type { get; set; }
		public string url { get; set; }
		public int lineNumber { get; set; }
		public Stack stack { get; set; }
	}

	public class Stack
	{
		public Callframe[] callFrames { get; set; }
	}

	public class Callframe
	{
		public string functionName { get; set; }
		public string scriptId { get; set; }
		public string url { get; set; }
		public int lineNumber { get; set; }
		public int columnNumber { get; set; }
	}

	public class Redirectresponse
	{
		public string url { get; set; }
		public int status { get; set; }
		public string statusText { get; set; }
		public Headers1 headers { get; set; }
		public string mimeType { get; set; }
		public Requestheaders requestHeaders { get; set; }
		public string remoteIPAddress { get; set; }
		public int remotePort { get; set; }
		public bool fromPrefetchCache { get; set; }
		public int encodedDataLength { get; set; }
		public Timing1 timing { get; set; }
		public string protocol { get; set; }
		public string securityState { get; set; }
		public Securitydetails securityDetails { get; set; }
	}

	public class Headers1
	{
		public string status { get; set; }
		public string contenttype { get; set; }
		public string cachecontrol { get; set; }
		public string stricttransportsecurity { get; set; }
		public string location { get; set; }
		public string xcloudtracecontext { get; set; }
		public string date { get; set; }
		public string server { get; set; }
		public string contentlength { get; set; }
	}

	public class Requestheaders
	{
		public string method { get; set; }
		public string authority { get; set; }
		public string scheme { get; set; }
		public string path { get; set; }
		public string pragma { get; set; }
		public string cachecontrol { get; set; }
		public string upgradeinsecurerequests { get; set; }
		public string useragent { get; set; }
		public string accept { get; set; }
		public string secfetchsite { get; set; }
		public string acceptencoding { get; set; }
	}

	public class Timing1
	{
		public float requestTime { get; set; }
		public int proxyStart { get; set; }
		public int proxyEnd { get; set; }
		public float dnsStart { get; set; }
		public float dnsEnd { get; set; }
		public float connectStart { get; set; }
		public float connectEnd { get; set; }
		public float sslStart { get; set; }
		public float sslEnd { get; set; }
		public int workerStart { get; set; }
		public int workerReady { get; set; }
		public float sendStart { get; set; }
		public float sendEnd { get; set; }
		public int pushStart { get; set; }
		public int pushEnd { get; set; }
		public float receiveHeadersEnd { get; set; }
	}

	public class Securitydetails
	{
		public string protocol { get; set; }
		public string keyExchange { get; set; }
		public string keyExchangeGroup { get; set; }
		public string cipher { get; set; }
		public int certificateId { get; set; }
		public string subjectName { get; set; }
		public string[] sanList { get; set; }
		public string issuer { get; set; }
		public int validFrom { get; set; }
		public int validTo { get; set; }
		public object[] signedCertificateTimestampList { get; set; }
		public string certificateTransparencyCompliance { get; set; }
	}

	public class Response
	{
		public int encodedDataLength { get; set; }
		public int dataLength { get; set; }
		public string requestId { get; set; }
		public string type { get; set; }
		public Response1 response { get; set; }
		public string hash { get; set; }
		public int size { get; set; }
		public Asn asn { get; set; }
		public Geoip geoip { get; set; }
		public Rdns rdns { get; set; }
		public object[] hashmatches { get; set; }
	}

	public class Response1
	{
		public string url { get; set; }
		public int status { get; set; }
		public string statusText { get; set; }
		public Headers2 headers { get; set; }
		public string mimeType { get; set; }
		public Requestheaders1 requestHeaders { get; set; }
		public string remoteIPAddress { get; set; }
		public int remotePort { get; set; }
		public bool fromPrefetchCache { get; set; }
		public int encodedDataLength { get; set; }
		public Timing2 timing { get; set; }
		public string protocol { get; set; }
		public string securityState { get; set; }
		public Securitydetails1 securityDetails { get; set; }
		public Securityheader[] securityHeaders { get; set; }
	}

	public class Headers2
	{
		public string status { get; set; }
		public string server { get; set; }
		public string date { get; set; }
		public string contenttype { get; set; }
		public string link { get; set; }
		public string via { get; set; }
		public string altsvc { get; set; }
		public string lastmodified { get; set; }
		public string etag { get; set; }
		public string cachecontrol { get; set; }
		public string acceptranges { get; set; }
		public string contentlength { get; set; }
		public string expires { get; set; }
		public string stricttransportsecurity { get; set; }
		public string contentencoding { get; set; }
		public string xframeoptions { get; set; }
		public string accesscontrolalloworigin { get; set; }
		public string timingalloworigin { get; set; }
		public string xxssprotection { get; set; }
		public string accesscontrolallowheaders { get; set; }
		public string vary { get; set; }
		public string accesscontrolallowcredentials { get; set; }
		public string Date { get; set; }
		public string ContentEncoding { get; set; }
		public string XContentTypeOptions { get; set; }
		public string LastModified { get; set; }
		public string Age { get; set; }
		public string ExpectCT { get; set; }
		public string Vary { get; set; }
		public string ContentType { get; set; }
		public string CacheControl { get; set; }
		public string PublicKeyPinsReportOnly { get; set; }
		public string AcceptRanges { get; set; }
		public string XRobotsTag { get; set; }
		public string ContentLength { get; set; }
		public string XXSSProtection { get; set; }
		public string Expires { get; set; }
		public string xcontenttypeoptions { get; set; }
		public string sectioniotag { get; set; }
		public string age { get; set; }
		public string sectioniocache { get; set; }
		public string accesscontrolmaxage { get; set; }
		public string sectioniooriginstatus { get; set; }
		public string xcachehit { get; set; }
		public string sectionioorigintimeseconds { get; set; }
		public string sectionioid { get; set; }
		public string Server { get; set; }
		public string ETag { get; set; }
		public string Connection { get; set; }
		public string ReferrerPolicy { get; set; }
		public string pragma { get; set; }
		public string ContentSecurityPolicy { get; set; }
		public string SetCookie { get; set; }
		public string TransferEncoding { get; set; }
		public string XPardotRoute { get; set; }
		public string XPardotLB { get; set; }
		public string Pragma { get; set; }
		public string XPardotRsp { get; set; }
		public string P3p { get; set; }
	}

	public class Requestheaders1
	{
		public string method { get; set; }
		public string authority { get; set; }
		public string scheme { get; set; }
		public string path { get; set; }
		public string pragma { get; set; }
		public string cachecontrol { get; set; }
		public string upgradeinsecurerequests { get; set; }
		public string useragent { get; set; }
		public string accept { get; set; }
		public string secfetchsite { get; set; }
		public string acceptencoding { get; set; }
		public string Host { get; set; }
		public string Connection { get; set; }
		public string Pragma { get; set; }
		public string CacheControl { get; set; }
		public string UpgradeInsecureRequests { get; set; }
		public string UserAgent { get; set; }
		public string SecFetchMode { get; set; }
		public string Accept { get; set; }
		public string SecFetchSite { get; set; }
		public string Referer { get; set; }
		public string AcceptEncoding { get; set; }
		public string secfetchmode { get; set; }
		public string referer { get; set; }
	}

	public class Timing2
	{
		public float requestTime { get; set; }
		public int proxyStart { get; set; }
		public int proxyEnd { get; set; }
		public float dnsStart { get; set; }
		public float dnsEnd { get; set; }
		public float connectStart { get; set; }
		public float connectEnd { get; set; }
		public float sslStart { get; set; }
		public float sslEnd { get; set; }
		public int workerStart { get; set; }
		public int workerReady { get; set; }
		public float sendStart { get; set; }
		public float sendEnd { get; set; }
		public int pushStart { get; set; }
		public int pushEnd { get; set; }
		public float receiveHeadersEnd { get; set; }
	}

	public class Securitydetails1
	{
		public string protocol { get; set; }
		public string keyExchange { get; set; }
		public string keyExchangeGroup { get; set; }
		public string cipher { get; set; }
		public int certificateId { get; set; }
		public string subjectName { get; set; }
		public string[] sanList { get; set; }
		public string issuer { get; set; }
		public int validFrom { get; set; }
		public int validTo { get; set; }
		public object[] signedCertificateTimestampList { get; set; }
		public string certificateTransparencyCompliance { get; set; }
	}

	public class Securityheader
	{
		public string name { get; set; }
		public string value { get; set; }
	}

	public class Asn
	{
		public string ip { get; set; }
		public string asn { get; set; }
		public string country { get; set; }
		public string registrar { get; set; }
		public string date { get; set; }
		public string description { get; set; }
		public string route { get; set; }
		public string name { get; set; }
	}

	public class Geoip
	{
		public object range { get; set; }
		public string country { get; set; }
		public string region { get; set; }
		public string eu { get; set; }
		public string timezone { get; set; }
		public string city { get; set; }
		public float[] ll { get; set; }
		public int metro { get; set; }
		public int area { get; set; }
		public string country_name { get; set; }
	}

	public class Rdns
	{
		public string ip { get; set; }
		public string ptr { get; set; }
	}

	public class Initiatorinfo
	{
		public string url { get; set; }
		public string host { get; set; }
		public string type { get; set; }
	}

	public class Request3
	{
		public string requestId { get; set; }
		public string loaderId { get; set; }
		public string documentURL { get; set; }
		public Request4 request { get; set; }
		public float timestamp { get; set; }
		public float wallTime { get; set; }
		public Initiator1 initiator { get; set; }
		public string type { get; set; }
		public string frameId { get; set; }
		public bool hasUserGesture { get; set; }
		public Redirectresponse1 redirectResponse { get; set; }
	}

	public class Request4
	{
		public string url { get; set; }
		public string method { get; set; }
		public Headers3 headers { get; set; }
		public string mixedContentType { get; set; }
		public string initialPriority { get; set; }
		public string referrerPolicy { get; set; }
	}

	public class Headers3
	{
		public string UpgradeInsecureRequests { get; set; }
		public string UserAgent { get; set; }
	}

	public class Initiator1
	{
		public string type { get; set; }
	}

	public class Redirectresponse1
	{
		public string url { get; set; }
		public int status { get; set; }
		public string statusText { get; set; }
		public Headers4 headers { get; set; }
		public string mimeType { get; set; }
		public string remoteIPAddress { get; set; }
		public int remotePort { get; set; }
		public bool fromPrefetchCache { get; set; }
		public int encodedDataLength { get; set; }
		public Timing3 timing { get; set; }
		public string protocol { get; set; }
		public string securityState { get; set; }
		public Requestheaders2 requestHeaders { get; set; }
		public Securitydetails2 securityDetails { get; set; }
		public Asn1 asn { get; set; }
		public Geoip1 geoip { get; set; }
	}

	public class Headers4
	{
		public string Location { get; set; }
		public string NonAuthoritativeReason { get; set; }
		public string status { get; set; }
		public string contenttype { get; set; }
		public string cachecontrol { get; set; }
		public string stricttransportsecurity { get; set; }
		public string location { get; set; }
		public string xcloudtracecontext { get; set; }
		public string date { get; set; }
		public string server { get; set; }
		public string contentlength { get; set; }
	}

	public class Timing3
	{
		public float requestTime { get; set; }
		public int proxyStart { get; set; }
		public int proxyEnd { get; set; }
		public float dnsStart { get; set; }
		public float dnsEnd { get; set; }
		public float connectStart { get; set; }
		public float connectEnd { get; set; }
		public float sslStart { get; set; }
		public float sslEnd { get; set; }
		public int workerStart { get; set; }
		public int workerReady { get; set; }
		public float sendStart { get; set; }
		public float sendEnd { get; set; }
		public int pushStart { get; set; }
		public int pushEnd { get; set; }
		public float receiveHeadersEnd { get; set; }
	}

	public class Requestheaders2
	{
		public string method { get; set; }
		public string authority { get; set; }
		public string scheme { get; set; }
		public string path { get; set; }
		public string pragma { get; set; }
		public string cachecontrol { get; set; }
		public string upgradeinsecurerequests { get; set; }
		public string useragent { get; set; }
		public string accept { get; set; }
		public string secfetchsite { get; set; }
		public string acceptencoding { get; set; }
	}

	public class Securitydetails2
	{
		public string protocol { get; set; }
		public string keyExchange { get; set; }
		public string keyExchangeGroup { get; set; }
		public string cipher { get; set; }
		public int certificateId { get; set; }
		public string subjectName { get; set; }
		public string[] sanList { get; set; }
		public string issuer { get; set; }
		public int validFrom { get; set; }
		public int validTo { get; set; }
		public object[] signedCertificateTimestampList { get; set; }
		public string certificateTransparencyCompliance { get; set; }
	}

	public class Asn1
	{
		public string ip { get; set; }
		public string asn { get; set; }
		public string country { get; set; }
		public string registrar { get; set; }
		public string date { get; set; }
		public string description { get; set; }
		public string route { get; set; }
		public string name { get; set; }
	}

	public class Geoip1
	{
		public string range { get; set; }
		public string country { get; set; }
		public string region { get; set; }
		public string city { get; set; }
		public float[] ll { get; set; }
		public int metro { get; set; }
		public int area { get; set; }
		public string eu { get; set; }
		public string timezone { get; set; }
		public string country_name { get; set; }
	}

	public class Cooky
	{
		public string name { get; set; }
		public string value { get; set; }
		public string domain { get; set; }
		public string path { get; set; }
		public float expires { get; set; }
		public int size { get; set; }
		public bool httpOnly { get; set; }
		public bool secure { get; set; }
		public bool session { get; set; }
	}

	public class Console
	{
		public Message message { get; set; }
	}

	public class Message
	{
		public string source { get; set; }
		public string level { get; set; }
		public string text { get; set; }
		public string url { get; set; }
		public int line { get; set; }
		public int column { get; set; }
	}

	public class Link
	{
		public string href { get; set; }
		public string text { get; set; }
	}

	public class Global
	{
		public string prop { get; set; }
		public string type { get; set; }
	}

	public class Stats
	{
		public Resourcestat[] resourceStats { get; set; }
		public Protocolstat[] protocolStats { get; set; }
		public Tlsstat[] tlsStats { get; set; }
		public Serverstat[] serverStats { get; set; }
		public Domainstat[] domainStats { get; set; }
		public Regdomainstat[] regDomainStats { get; set; }
		public int secureRequests { get; set; }
		public int securePercentage { get; set; }
		public int IPv6Percentage { get; set; }
		public int uniqCountries { get; set; }
		public int totalLinks { get; set; }
		public int malicious { get; set; }
		public int adBlocked { get; set; }
		public Ipstat[] ipStats { get; set; }
	}

	public class Resourcestat
	{
		public int count { get; set; }
		public int size { get; set; }
		public int encodedSize { get; set; }
		public int latency { get; set; }
		public string[] countries { get; set; }
		public string[] ips { get; set; }
		public string type { get; set; }
		public string compression { get; set; }
		public object percentage { get; set; }
	}

	public class Protocolstat
	{
		public int count { get; set; }
		public int size { get; set; }
		public int encodedSize { get; set; }
		public string[] ips { get; set; }
		public string[] countries { get; set; }
		public Securitystate securityState { get; set; }
		public string protocol { get; set; }
	}

	public class Securitystate
	{
	}

	public class Tlsstat
	{
		public int count { get; set; }
		public int size { get; set; }
		public int encodedSize { get; set; }
		public string[] ips { get; set; }
		public string[] countries { get; set; }
		public Protocols protocols { get; set; }
		public string securityState { get; set; }
	}

	public class Protocols
	{
		public int TLS12ECDHE_RSAAES_128_GCM { get; set; }
		public int TLS13AES_128_GCM { get; set; }
		public int TLS12ECDHE_RSAAES_256_GCM { get; set; }
	}

	public class Serverstat
	{
		public int count { get; set; }
		public int size { get; set; }
		public int encodedSize { get; set; }
		public string[] ips { get; set; }
		public string[] countries { get; set; }
		public string server { get; set; }
	}

	public class Domainstat
	{
		public int count { get; set; }
		public string[] ips { get; set; }
		public string domain { get; set; }
		public int size { get; set; }
		public int encodedSize { get; set; }
		public string[] countries { get; set; }
		public int index { get; set; }
		public string[] initiators { get; set; }
		public int redirects { get; set; }
	}

	public class Regdomainstat
	{
		public int count { get; set; }
		public string[] ips { get; set; }
		public string regDomain { get; set; }
		public int size { get; set; }
		public int encodedSize { get; set; }
		public object[] countries { get; set; }
		public int index { get; set; }
		public object[] subDomains { get; set; }
		public int redirects { get; set; }
	}

	public class Ipstat
	{
		public int requests { get; set; }
		public string[] domains { get; set; }
		public string ip { get; set; }
		public Asn2 asn { get; set; }
		public Dns dns { get; set; }
		public int size { get; set; }
		public int encodedSize { get; set; }
		public string[] countries { get; set; }
		public int index { get; set; }
		public bool ipv6 { get; set; }
		public int redirects { get; set; }
		public object count { get; set; }
		public Geoip2 geoip { get; set; }
		public Rdns1 rdns { get; set; }
	}

	public class Asn2
	{
		public string ip { get; set; }
		public string asn { get; set; }
		public string country { get; set; }
		public string registrar { get; set; }
		public string date { get; set; }
		public string description { get; set; }
		public string route { get; set; }
		public string name { get; set; }
	}

	public class Dns
	{
	}

	public class Geoip2
	{
		public object range { get; set; }
		public string country { get; set; }
		public string region { get; set; }
		public string city { get; set; }
		public float[] ll { get; set; }
		public int metro { get; set; }
		public int area { get; set; }
		public string eu { get; set; }
		public string timezone { get; set; }
		public string country_name { get; set; }
	}

	public class Rdns1
	{
		public string ip { get; set; }
		public string ptr { get; set; }
	}

	public class Meta
	{
		public Processors processors { get; set; }
	}

	public class Processors
	{
		public Download download { get; set; }
		public Geoip3 geoip { get; set; }
		public Asn3 asn { get; set; }
		public Wappa wappa { get; set; }
		public Rdns2 rdns { get; set; }
		public Done done { get; set; }
	}

	public class Download
	{
		public string state { get; set; }
		public object[] data { get; set; }
	}

	public class Geoip3
	{
		public string state { get; set; }
		public Datum[] data { get; set; }
	}

	public class Datum
	{
		public string ip { get; set; }
		public Geoip4 geoip { get; set; }
	}

	public class Geoip4
	{
		public object range { get; set; }
		public string country { get; set; }
		public string region { get; set; }
		public string eu { get; set; }
		public string timezone { get; set; }
		public string city { get; set; }
		public float[] ll { get; set; }
		public int metro { get; set; }
		public int area { get; set; }
		public string country_name { get; set; }
	}

	public class Asn3
	{
		public string state { get; set; }
		public Datum1[] data { get; set; }
	}

	public class Datum1
	{
		public string ip { get; set; }
		public string asn { get; set; }
		public string country { get; set; }
		public string registrar { get; set; }
		public string date { get; set; }
		public string description { get; set; }
		public string route { get; set; }
		public string name { get; set; }
	}

	public class Wappa
	{
		public string state { get; set; }
		public Datum2[] data { get; set; }
	}

	public class Datum2
	{
		public string app { get; set; }
		public Confidence[] confidence { get; set; }
		public int confidenceTotal { get; set; }
		public string icon { get; set; }
		public string website { get; set; }
		public Category[] categories { get; set; }
		public string version { get; set; }
	}

	public class Confidence
	{
		public string pattern { get; set; }
		public int confidence { get; set; }
		public string implied_by { get; set; }
	}

	public class Category
	{
		public string name { get; set; }
		public int priority { get; set; }
	}

	public class Rdns2
	{
		public string state { get; set; }
		public Datum3[] data { get; set; }
	}

	public class Datum3
	{
		public string ip { get; set; }
		public string ptr { get; set; }
	}

	public class Done
	{
		public string state { get; set; }
		public Data1 data { get; set; }
	}

	public class Data1
	{
		public string state { get; set; }
	}

	public class Task
	{
		public string uuid { get; set; }
		public DateTime time { get; set; }
		public string url { get; set; }
		public string visibility { get; set; }
		public Options options { get; set; }
		public string method { get; set; }
		public string source { get; set; }
		public string userAgent { get; set; }
		public string reportURL { get; set; }
		public string screenshotURL { get; set; }
		public string domURL { get; set; }
	}

	public class Options
	{
		public string useragent { get; set; }
	}

	public class Page
	{
		public string url { get; set; }
		public string domain { get; set; }
		public string country { get; set; }
		public string city { get; set; }
		public string server { get; set; }
		public string ip { get; set; }
		public string ptr { get; set; }
		public string asn { get; set; }
		public string asnname { get; set; }
	}

	public class Lists
	{
		public string[] ips { get; set; }
		public string[] countries { get; set; }
		public string[] asns { get; set; }
		public string[] domains { get; set; }
		public string[] servers { get; set; }
		public string[] urls { get; set; }
		public string[] linkDomains { get; set; }
		public Certificate[] certificates { get; set; }
		public string[] hashes { get; set; }
	}

	public class Certificate
	{
		public string subjectName { get; set; }
		public string issuer { get; set; }
		public int validFrom { get; set; }
		public int validTo { get; set; }
	}

	public class Verdicts
	{
		public Overall overall { get; set; }
		public Urlscan urlscan { get; set; }
		public Engines engines { get; set; }
		public Community community { get; set; }
	}

	public class Overall
	{
		public int score { get; set; }
		public object[] categories { get; set; }
		public object[] brands { get; set; }
		public object[] tags { get; set; }
		public bool malicious { get; set; }
		public int hasVerdicts { get; set; }
	}

	public class Urlscan
	{
		public int score { get; set; }
		public object[] categories { get; set; }
		public object[] brands { get; set; }
		public object[] tags { get; set; }
		public object[] detectionDetails { get; set; }
		public bool malicious { get; set; }
	}

	public class Engines
	{
		public int score { get; set; }
		public object[] malicious { get; set; }
		public object[] benign { get; set; }
		public int maliciousTotal { get; set; }
		public int benignTotal { get; set; }
		public object[] verdicts { get; set; }
		public int enginesTotal { get; set; }
	}

	public class Community
	{
		public int score { get; set; }
		public object[] votes { get; set; }
		public int votesTotal { get; set; }
		public int votesMalicious { get; set; }
		public int votesBenign { get; set; }
		public object[] tags { get; set; }
		public object[] categories { get; set; }
	}
}
