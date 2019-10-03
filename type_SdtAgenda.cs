using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using System.Data;
using System.Data.SqlClient;
using GeneXus.Data;
using com.genexus;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using System.Runtime.Remoting;
using GeneXus.WebControls;
using GeneXus.Http;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Reflection;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   [Serializable]
   public class SdtAgenda : GxSilentTrnSdt, System.Web.SessionState.IRequiresSessionState
   {
      public SdtAgenda( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         constructorCallingAssembly = Assembly.GetCallingAssembly() ;
         initialize();
         context.SetTheme("Fantastic");
      }

      public SdtAgenda( IGxContext context )
      {
         this.context = context;
         constructorCallingAssembly = Assembly.GetCallingAssembly() ;
         initialize();
      }

      public void Load( String AV41ClinicaCodigo ,
                        String AV56AgendaId )
      {
         IGxSilentTrn obj ;
         obj = getTransaction() ;
         obj.LoadKey(new Object[] {(String)AV41ClinicaCodigo,(String)AV56AgendaId});
         return  ;
      }

      public IGxCollection GetMessages( )
      {
         short item = 1 ;
         IGxCollection msgs = new GxObjectCollection( context, "Messages.Message", "Genexus", "SdtMessages_Message", "GeneXus.Programs") ;
         SdtMessages_Message m1 ;
         IGxSilentTrn trn = getTransaction() ;
         msglist msgList = trn.GetMessages() ;
         while ( item <= msgList.ItemCount )
         {
            m1 = new SdtMessages_Message(context) ;
            m1.gxTpr_Id = msgList.getItemValue(item) ;
            m1.gxTpr_Description = msgList.getItemText(item) ;
            m1.gxTpr_Type = msgList.getItemType(item) ;
            msgs.Add(m1, 0);
            item = (short)(item+1) ;
         }
         return msgs ;
      }

      public override short readxml( GXXMLReader oReader ,
                                     String sName )
      {
         short GXSoapError = 1 ;
         sTagName = oReader.Name ;
         if ( oReader.IsSimple == 0 )
         {
            GXSoapError = oReader.Read() ;
            nOutParmCount = 0 ;
            while ( ( ( StringUtil.StrCmp(oReader.Name, sTagName) != 0 ) || ( oReader.NodeType == 1 ) ) && ( GXSoapError > 0 ) )
            {
               readOk = 0 ;
               if ( StringUtil.StrCmp2( oReader.LocalName, "ClinicaCodigo") )
               {
                  gxTv_SdtAgenda_Clinicacodigo = oReader.Value ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "AgendaId") )
               {
                  gxTv_SdtAgenda_Agendaid = oReader.Value ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "AgendaNombre") )
               {
                  gxTv_SdtAgenda_Agendanombre = oReader.Value ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "AgendaInicial") )
               {
                  if ( ( StringUtil.StrCmp(oReader.Value, "0000-00-00T00:00:00") == 0 ) || ( oReader.ExistsAttribute("xsi:nil") == 1 ) )
                  {
                     gxTv_SdtAgenda_Agendainicial = (DateTime)(DateTime.MinValue) ;
                  }
                  else
                  {
                     gxTv_SdtAgenda_Agendainicial = context.localUtil.YMDHMSToT( (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 1, 4), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 6, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 9, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 12, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 15, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 18, 2), "."))) ;
                  }
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "AgendaFinal") )
               {
                  if ( ( StringUtil.StrCmp(oReader.Value, "0000-00-00T00:00:00") == 0 ) || ( oReader.ExistsAttribute("xsi:nil") == 1 ) )
                  {
                     gxTv_SdtAgenda_Agendafinal = (DateTime)(DateTime.MinValue) ;
                  }
                  else
                  {
                     gxTv_SdtAgenda_Agendafinal = context.localUtil.YMDHMSToT( (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 1, 4), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 6, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 9, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 12, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 15, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 18, 2), "."))) ;
                  }
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "AgendaObs") )
               {
                  gxTv_SdtAgenda_Agendaobs = oReader.Value ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "Mode") )
               {
                  gxTv_SdtAgenda_Mode = oReader.Value ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "Initialized") )
               {
                  gxTv_SdtAgenda_Initialized = (short)(NumberUtil.Val( oReader.Value, ".")) ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "ClinicaCodigo_Z") )
               {
                  gxTv_SdtAgenda_Clinicacodigo_Z = oReader.Value ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "AgendaId_Z") )
               {
                  gxTv_SdtAgenda_Agendaid_Z = oReader.Value ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "AgendaNombre_Z") )
               {
                  gxTv_SdtAgenda_Agendanombre_Z = oReader.Value ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "AgendaInicial_Z") )
               {
                  if ( ( StringUtil.StrCmp(oReader.Value, "0000-00-00T00:00:00") == 0 ) || ( oReader.ExistsAttribute("xsi:nil") == 1 ) )
                  {
                     gxTv_SdtAgenda_Agendainicial_Z = (DateTime)(DateTime.MinValue) ;
                  }
                  else
                  {
                     gxTv_SdtAgenda_Agendainicial_Z = context.localUtil.YMDHMSToT( (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 1, 4), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 6, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 9, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 12, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 15, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 18, 2), "."))) ;
                  }
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "AgendaFinal_Z") )
               {
                  if ( ( StringUtil.StrCmp(oReader.Value, "0000-00-00T00:00:00") == 0 ) || ( oReader.ExistsAttribute("xsi:nil") == 1 ) )
                  {
                     gxTv_SdtAgenda_Agendafinal_Z = (DateTime)(DateTime.MinValue) ;
                  }
                  else
                  {
                     gxTv_SdtAgenda_Agendafinal_Z = context.localUtil.YMDHMSToT( (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 1, 4), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 6, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 9, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 12, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 15, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( oReader.Value, 18, 2), "."))) ;
                  }
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "AgendaObs_Z") )
               {
                  gxTv_SdtAgenda_Agendaobs_Z = oReader.Value ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               nOutParmCount = (short)(nOutParmCount+1) ;
               if ( readOk == 0 )
               {
                  context.sSOAPErrMsg = context.sSOAPErrMsg + "Error reading " + sTagName + StringUtil.NewLine( ) ;
                  GXSoapError = (short)(nOutParmCount*-1) ;
               }
            }
         }
         return GXSoapError ;
      }

      public override void writexml( GXXMLWriter oWriter ,
                                     String sName ,
                                     String sNameSpace )
      {
         if ( String.IsNullOrEmpty(StringUtil.RTrim( sName)) )
         {
            sName = "Agenda" ;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( sNameSpace)) )
         {
            sNameSpace = "Clinica" ;
         }
         oWriter.WriteStartElement(sName);
         if ( StringUtil.StrCmp(StringUtil.Left( sNameSpace, 10), "[*:nosend]") != 0 )
         {
            oWriter.WriteAttribute("xmlns", sNameSpace);
         }
         else
         {
            sNameSpace = StringUtil.Right( sNameSpace, (short)(StringUtil.Len( sNameSpace)-10)) ;
         }
         oWriter.WriteElement("ClinicaCodigo", StringUtil.RTrim( gxTv_SdtAgenda_Clinicacodigo));
         if ( StringUtil.StrCmp(sNameSpace, "Clinica") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Clinica");
         }
         oWriter.WriteElement("AgendaId", StringUtil.RTrim( gxTv_SdtAgenda_Agendaid));
         if ( StringUtil.StrCmp(sNameSpace, "Clinica") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Clinica");
         }
         oWriter.WriteElement("AgendaNombre", StringUtil.RTrim( gxTv_SdtAgenda_Agendanombre));
         if ( StringUtil.StrCmp(sNameSpace, "Clinica") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Clinica");
         }
         if ( (DateTime.MinValue==gxTv_SdtAgenda_Agendainicial) )
         {
            oWriter.WriteStartElement("AgendaInicial");
            oWriter.WriteAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
            oWriter.WriteAttribute("xsi:nil", "true");
            oWriter.WriteEndElement();
         }
         else
         {
            sDateCnv = "" ;
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_SdtAgenda_Agendainicial)), 10, 0)) ;
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad ;
            sDateCnv = sDateCnv + "-" ;
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_SdtAgenda_Agendainicial)), 10, 0)) ;
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
            sDateCnv = sDateCnv + "-" ;
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_SdtAgenda_Agendainicial)), 10, 0)) ;
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
            sDateCnv = sDateCnv + "T" ;
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( gxTv_SdtAgenda_Agendainicial)), 10, 0)) ;
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
            sDateCnv = sDateCnv + ":" ;
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( gxTv_SdtAgenda_Agendainicial)), 10, 0)) ;
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
            sDateCnv = sDateCnv + ":" ;
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( gxTv_SdtAgenda_Agendainicial)), 10, 0)) ;
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
            oWriter.WriteElement("AgendaInicial", sDateCnv);
            if ( StringUtil.StrCmp(sNameSpace, "Clinica") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Clinica");
            }
         }
         if ( (DateTime.MinValue==gxTv_SdtAgenda_Agendafinal) )
         {
            oWriter.WriteStartElement("AgendaFinal");
            oWriter.WriteAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
            oWriter.WriteAttribute("xsi:nil", "true");
            oWriter.WriteEndElement();
         }
         else
         {
            sDateCnv = "" ;
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_SdtAgenda_Agendafinal)), 10, 0)) ;
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad ;
            sDateCnv = sDateCnv + "-" ;
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_SdtAgenda_Agendafinal)), 10, 0)) ;
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
            sDateCnv = sDateCnv + "-" ;
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_SdtAgenda_Agendafinal)), 10, 0)) ;
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
            sDateCnv = sDateCnv + "T" ;
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( gxTv_SdtAgenda_Agendafinal)), 10, 0)) ;
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
            sDateCnv = sDateCnv + ":" ;
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( gxTv_SdtAgenda_Agendafinal)), 10, 0)) ;
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
            sDateCnv = sDateCnv + ":" ;
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( gxTv_SdtAgenda_Agendafinal)), 10, 0)) ;
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
            oWriter.WriteElement("AgendaFinal", sDateCnv);
            if ( StringUtil.StrCmp(sNameSpace, "Clinica") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Clinica");
            }
         }
         oWriter.WriteElement("AgendaObs", StringUtil.RTrim( gxTv_SdtAgenda_Agendaobs));
         if ( StringUtil.StrCmp(sNameSpace, "Clinica") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Clinica");
         }
         oWriter.WriteElement("Mode", StringUtil.RTrim( gxTv_SdtAgenda_Mode));
         if ( StringUtil.StrCmp(sNameSpace, "Clinica") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Clinica");
         }
         oWriter.WriteElement("Initialized", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_SdtAgenda_Initialized), 4, 0)));
         if ( StringUtil.StrCmp(sNameSpace, "Clinica") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Clinica");
         }
         oWriter.WriteElement("ClinicaCodigo_Z", StringUtil.RTrim( gxTv_SdtAgenda_Clinicacodigo_Z));
         if ( StringUtil.StrCmp(sNameSpace, "Clinica") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Clinica");
         }
         oWriter.WriteElement("AgendaId_Z", StringUtil.RTrim( gxTv_SdtAgenda_Agendaid_Z));
         if ( StringUtil.StrCmp(sNameSpace, "Clinica") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Clinica");
         }
         oWriter.WriteElement("AgendaNombre_Z", StringUtil.RTrim( gxTv_SdtAgenda_Agendanombre_Z));
         if ( StringUtil.StrCmp(sNameSpace, "Clinica") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Clinica");
         }
         if ( (DateTime.MinValue==gxTv_SdtAgenda_Agendainicial_Z) )
         {
            oWriter.WriteStartElement("AgendaInicial_Z");
            oWriter.WriteAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
            oWriter.WriteAttribute("xsi:nil", "true");
            oWriter.WriteEndElement();
         }
         else
         {
            sDateCnv = "" ;
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_SdtAgenda_Agendainicial_Z)), 10, 0)) ;
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad ;
            sDateCnv = sDateCnv + "-" ;
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_SdtAgenda_Agendainicial_Z)), 10, 0)) ;
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
            sDateCnv = sDateCnv + "-" ;
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_SdtAgenda_Agendainicial_Z)), 10, 0)) ;
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
            sDateCnv = sDateCnv + "T" ;
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( gxTv_SdtAgenda_Agendainicial_Z)), 10, 0)) ;
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
            sDateCnv = sDateCnv + ":" ;
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( gxTv_SdtAgenda_Agendainicial_Z)), 10, 0)) ;
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
            sDateCnv = sDateCnv + ":" ;
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( gxTv_SdtAgenda_Agendainicial_Z)), 10, 0)) ;
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
            oWriter.WriteElement("AgendaInicial_Z", sDateCnv);
            if ( StringUtil.StrCmp(sNameSpace, "Clinica") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Clinica");
            }
         }
         if ( (DateTime.MinValue==gxTv_SdtAgenda_Agendafinal_Z) )
         {
            oWriter.WriteStartElement("AgendaFinal_Z");
            oWriter.WriteAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
            oWriter.WriteAttribute("xsi:nil", "true");
            oWriter.WriteEndElement();
         }
         else
         {
            sDateCnv = "" ;
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_SdtAgenda_Agendafinal_Z)), 10, 0)) ;
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad ;
            sDateCnv = sDateCnv + "-" ;
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_SdtAgenda_Agendafinal_Z)), 10, 0)) ;
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
            sDateCnv = sDateCnv + "-" ;
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_SdtAgenda_Agendafinal_Z)), 10, 0)) ;
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
            sDateCnv = sDateCnv + "T" ;
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( gxTv_SdtAgenda_Agendafinal_Z)), 10, 0)) ;
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
            sDateCnv = sDateCnv + ":" ;
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( gxTv_SdtAgenda_Agendafinal_Z)), 10, 0)) ;
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
            sDateCnv = sDateCnv + ":" ;
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( gxTv_SdtAgenda_Agendafinal_Z)), 10, 0)) ;
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
            oWriter.WriteElement("AgendaFinal_Z", sDateCnv);
            if ( StringUtil.StrCmp(sNameSpace, "Clinica") != 0 )
            {
               oWriter.WriteAttribute("xmlns", "Clinica");
            }
         }
         oWriter.WriteElement("AgendaObs_Z", StringUtil.RTrim( gxTv_SdtAgenda_Agendaobs_Z));
         if ( StringUtil.StrCmp(sNameSpace, "Clinica") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Clinica");
         }
         oWriter.WriteEndElement();
         return  ;
      }

      public override void ToJSON( )
      {
         AddObjectProperty("ClinicaCodigo", (Object)(gxTv_SdtAgenda_Clinicacodigo));
         AddObjectProperty("AgendaId", (Object)(gxTv_SdtAgenda_Agendaid));
         AddObjectProperty("AgendaNombre", (Object)(gxTv_SdtAgenda_Agendanombre));
         sDateCnv = "" ;
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_SdtAgenda_Agendainicial)), 10, 0)) ;
         sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad ;
         sDateCnv = sDateCnv + "-" ;
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_SdtAgenda_Agendainicial)), 10, 0)) ;
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
         sDateCnv = sDateCnv + "-" ;
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_SdtAgenda_Agendainicial)), 10, 0)) ;
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
         sDateCnv = sDateCnv + "T" ;
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( gxTv_SdtAgenda_Agendainicial)), 10, 0)) ;
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
         sDateCnv = sDateCnv + ":" ;
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( gxTv_SdtAgenda_Agendainicial)), 10, 0)) ;
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
         sDateCnv = sDateCnv + ":" ;
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( gxTv_SdtAgenda_Agendainicial)), 10, 0)) ;
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
         AddObjectProperty("AgendaInicial", (Object)(sDateCnv));
         sDateCnv = "" ;
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_SdtAgenda_Agendafinal)), 10, 0)) ;
         sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad ;
         sDateCnv = sDateCnv + "-" ;
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_SdtAgenda_Agendafinal)), 10, 0)) ;
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
         sDateCnv = sDateCnv + "-" ;
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_SdtAgenda_Agendafinal)), 10, 0)) ;
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
         sDateCnv = sDateCnv + "T" ;
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( gxTv_SdtAgenda_Agendafinal)), 10, 0)) ;
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
         sDateCnv = sDateCnv + ":" ;
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( gxTv_SdtAgenda_Agendafinal)), 10, 0)) ;
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
         sDateCnv = sDateCnv + ":" ;
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( gxTv_SdtAgenda_Agendafinal)), 10, 0)) ;
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
         AddObjectProperty("AgendaFinal", (Object)(sDateCnv));
         AddObjectProperty("AgendaObs", (Object)(gxTv_SdtAgenda_Agendaobs));
         AddObjectProperty("Mode", (Object)(gxTv_SdtAgenda_Mode));
         AddObjectProperty("Initialized", (Object)(gxTv_SdtAgenda_Initialized));
         AddObjectProperty("ClinicaCodigo_Z", (Object)(gxTv_SdtAgenda_Clinicacodigo_Z));
         AddObjectProperty("AgendaId_Z", (Object)(gxTv_SdtAgenda_Agendaid_Z));
         AddObjectProperty("AgendaNombre_Z", (Object)(gxTv_SdtAgenda_Agendanombre_Z));
         sDateCnv = "" ;
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_SdtAgenda_Agendainicial_Z)), 10, 0)) ;
         sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad ;
         sDateCnv = sDateCnv + "-" ;
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_SdtAgenda_Agendainicial_Z)), 10, 0)) ;
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
         sDateCnv = sDateCnv + "-" ;
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_SdtAgenda_Agendainicial_Z)), 10, 0)) ;
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
         sDateCnv = sDateCnv + "T" ;
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( gxTv_SdtAgenda_Agendainicial_Z)), 10, 0)) ;
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
         sDateCnv = sDateCnv + ":" ;
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( gxTv_SdtAgenda_Agendainicial_Z)), 10, 0)) ;
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
         sDateCnv = sDateCnv + ":" ;
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( gxTv_SdtAgenda_Agendainicial_Z)), 10, 0)) ;
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
         AddObjectProperty("AgendaInicial_Z", (Object)(sDateCnv));
         sDateCnv = "" ;
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_SdtAgenda_Agendafinal_Z)), 10, 0)) ;
         sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad ;
         sDateCnv = sDateCnv + "-" ;
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_SdtAgenda_Agendafinal_Z)), 10, 0)) ;
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
         sDateCnv = sDateCnv + "-" ;
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_SdtAgenda_Agendafinal_Z)), 10, 0)) ;
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
         sDateCnv = sDateCnv + "T" ;
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( gxTv_SdtAgenda_Agendafinal_Z)), 10, 0)) ;
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
         sDateCnv = sDateCnv + ":" ;
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( gxTv_SdtAgenda_Agendafinal_Z)), 10, 0)) ;
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
         sDateCnv = sDateCnv + ":" ;
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( gxTv_SdtAgenda_Agendafinal_Z)), 10, 0)) ;
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad ;
         AddObjectProperty("AgendaFinal_Z", (Object)(sDateCnv));
         AddObjectProperty("AgendaObs_Z", (Object)(gxTv_SdtAgenda_Agendaobs_Z));
         return  ;
      }

      public String gxTpr_Clinicacodigo
      {
         get {
            return gxTv_SdtAgenda_Clinicacodigo ;
         }

         set {
            if ( StringUtil.StrCmp(gxTv_SdtAgenda_Clinicacodigo, value) != 0 )
            {
               gxTv_SdtAgenda_Mode = "INS" ;
               this.gxTv_SdtAgenda_Clinicacodigo_Z_SetNull( );
               this.gxTv_SdtAgenda_Agendaid_Z_SetNull( );
               this.gxTv_SdtAgenda_Agendanombre_Z_SetNull( );
               this.gxTv_SdtAgenda_Agendainicial_Z_SetNull( );
               this.gxTv_SdtAgenda_Agendafinal_Z_SetNull( );
               this.gxTv_SdtAgenda_Agendaobs_Z_SetNull( );
            }
            gxTv_SdtAgenda_Clinicacodigo = (String)(value) ;
         }

      }

      public String gxTpr_Agendaid
      {
         get {
            return gxTv_SdtAgenda_Agendaid ;
         }

         set {
            if ( StringUtil.StrCmp(gxTv_SdtAgenda_Agendaid, value) != 0 )
            {
               gxTv_SdtAgenda_Mode = "INS" ;
               this.gxTv_SdtAgenda_Clinicacodigo_Z_SetNull( );
               this.gxTv_SdtAgenda_Agendaid_Z_SetNull( );
               this.gxTv_SdtAgenda_Agendanombre_Z_SetNull( );
               this.gxTv_SdtAgenda_Agendainicial_Z_SetNull( );
               this.gxTv_SdtAgenda_Agendafinal_Z_SetNull( );
               this.gxTv_SdtAgenda_Agendaobs_Z_SetNull( );
            }
            gxTv_SdtAgenda_Agendaid = (String)(value) ;
         }

      }

      public String gxTpr_Agendanombre
      {
         get {
            return gxTv_SdtAgenda_Agendanombre ;
         }

         set {
            gxTv_SdtAgenda_Agendanombre = (String)(value) ;
         }

      }

      public DateTime gxTpr_Agendainicial
      {
         get {
            return gxTv_SdtAgenda_Agendainicial ;
         }

         set {
            gxTv_SdtAgenda_Agendainicial = (DateTime)(value) ;
         }

      }

      public DateTime gxTpr_Agendafinal
      {
         get {
            return gxTv_SdtAgenda_Agendafinal ;
         }

         set {
            gxTv_SdtAgenda_Agendafinal = (DateTime)(value) ;
         }

      }

      public String gxTpr_Agendaobs
      {
         get {
            return gxTv_SdtAgenda_Agendaobs ;
         }

         set {
            gxTv_SdtAgenda_Agendaobs = (String)(value) ;
         }

      }

      public String gxTpr_Mode
      {
         get {
            return gxTv_SdtAgenda_Mode ;
         }

         set {
            gxTv_SdtAgenda_Mode = (String)(value) ;
         }

      }

      public void gxTv_SdtAgenda_Mode_SetNull( )
      {
         gxTv_SdtAgenda_Mode = "" ;
         return  ;
      }

      public bool gxTv_SdtAgenda_Mode_IsNull( )
      {
         return false ;
      }

      public short gxTpr_Initialized
      {
         get {
            return gxTv_SdtAgenda_Initialized ;
         }

         set {
            gxTv_SdtAgenda_Initialized = (short)(value) ;
         }

      }

      public void gxTv_SdtAgenda_Initialized_SetNull( )
      {
         gxTv_SdtAgenda_Initialized = 0 ;
         return  ;
      }

      public bool gxTv_SdtAgenda_Initialized_IsNull( )
      {
         return false ;
      }

      public String gxTpr_Clinicacodigo_Z
      {
         get {
            return gxTv_SdtAgenda_Clinicacodigo_Z ;
         }

         set {
            gxTv_SdtAgenda_Clinicacodigo_Z = (String)(value) ;
         }

      }

      public void gxTv_SdtAgenda_Clinicacodigo_Z_SetNull( )
      {
         gxTv_SdtAgenda_Clinicacodigo_Z = "" ;
         return  ;
      }

      public bool gxTv_SdtAgenda_Clinicacodigo_Z_IsNull( )
      {
         return false ;
      }

      public String gxTpr_Agendaid_Z
      {
         get {
            return gxTv_SdtAgenda_Agendaid_Z ;
         }

         set {
            gxTv_SdtAgenda_Agendaid_Z = (String)(value) ;
         }

      }

      public void gxTv_SdtAgenda_Agendaid_Z_SetNull( )
      {
         gxTv_SdtAgenda_Agendaid_Z = "" ;
         return  ;
      }

      public bool gxTv_SdtAgenda_Agendaid_Z_IsNull( )
      {
         return false ;
      }

      public String gxTpr_Agendanombre_Z
      {
         get {
            return gxTv_SdtAgenda_Agendanombre_Z ;
         }

         set {
            gxTv_SdtAgenda_Agendanombre_Z = (String)(value) ;
         }

      }

      public void gxTv_SdtAgenda_Agendanombre_Z_SetNull( )
      {
         gxTv_SdtAgenda_Agendanombre_Z = "" ;
         return  ;
      }

      public bool gxTv_SdtAgenda_Agendanombre_Z_IsNull( )
      {
         return false ;
      }

      public DateTime gxTpr_Agendainicial_Z
      {
         get {
            return gxTv_SdtAgenda_Agendainicial_Z ;
         }

         set {
            gxTv_SdtAgenda_Agendainicial_Z = (DateTime)(value) ;
         }

      }

      public void gxTv_SdtAgenda_Agendainicial_Z_SetNull( )
      {
         gxTv_SdtAgenda_Agendainicial_Z = (DateTime)(DateTime.MinValue) ;
         return  ;
      }

      public bool gxTv_SdtAgenda_Agendainicial_Z_IsNull( )
      {
         return false ;
      }

      public DateTime gxTpr_Agendafinal_Z
      {
         get {
            return gxTv_SdtAgenda_Agendafinal_Z ;
         }

         set {
            gxTv_SdtAgenda_Agendafinal_Z = (DateTime)(value) ;
         }

      }

      public void gxTv_SdtAgenda_Agendafinal_Z_SetNull( )
      {
         gxTv_SdtAgenda_Agendafinal_Z = (DateTime)(DateTime.MinValue) ;
         return  ;
      }

      public bool gxTv_SdtAgenda_Agendafinal_Z_IsNull( )
      {
         return false ;
      }

      public String gxTpr_Agendaobs_Z
      {
         get {
            return gxTv_SdtAgenda_Agendaobs_Z ;
         }

         set {
            gxTv_SdtAgenda_Agendaobs_Z = (String)(value) ;
         }

      }

      public void gxTv_SdtAgenda_Agendaobs_Z_SetNull( )
      {
         gxTv_SdtAgenda_Agendaobs_Z = "" ;
         return  ;
      }

      public bool gxTv_SdtAgenda_Agendaobs_Z_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtAgenda_Clinicacodigo = "" ;
         gxTv_SdtAgenda_Agendaid = "" ;
         gxTv_SdtAgenda_Agendanombre = "" ;
         gxTv_SdtAgenda_Agendainicial = (DateTime)(DateTime.MinValue) ;
         gxTv_SdtAgenda_Agendafinal = (DateTime)(DateTime.MinValue) ;
         gxTv_SdtAgenda_Agendaobs = "" ;
         gxTv_SdtAgenda_Mode = "" ;
         gxTv_SdtAgenda_Clinicacodigo_Z = "" ;
         gxTv_SdtAgenda_Agendaid_Z = "" ;
         gxTv_SdtAgenda_Agendanombre_Z = "" ;
         gxTv_SdtAgenda_Agendainicial_Z = (DateTime)(DateTime.MinValue) ;
         gxTv_SdtAgenda_Agendafinal_Z = (DateTime)(DateTime.MinValue) ;
         gxTv_SdtAgenda_Agendaobs_Z = "" ;
         sTagName = "" ;
         sDateCnv = "" ;
         sNumToPad = "" ;
         IGxSilentTrn obj ;
         obj = (IGxSilentTrn)ClassLoader.FindInstance( "agenda", "GeneXus.Programs.agenda_bc", new Object[] {context}, constructorCallingAssembly) ;
         obj.initialize();
         obj.SetSDT(this, 1);
         setTransaction( obj) ;
         obj.SetMode("INS");
         return  ;
      }

      private short gxTv_SdtAgenda_Initialized ;
      private short readOk ;
      private short nOutParmCount ;
      private String gxTv_SdtAgenda_Mode ;
      private String sTagName ;
      private String sDateCnv ;
      private String sNumToPad ;
      private DateTime gxTv_SdtAgenda_Agendainicial ;
      private DateTime gxTv_SdtAgenda_Agendafinal ;
      private DateTime gxTv_SdtAgenda_Agendainicial_Z ;
      private DateTime gxTv_SdtAgenda_Agendafinal_Z ;
      private String gxTv_SdtAgenda_Clinicacodigo ;
      private String gxTv_SdtAgenda_Agendaid ;
      private String gxTv_SdtAgenda_Agendanombre ;
      private String gxTv_SdtAgenda_Agendaobs ;
      private String gxTv_SdtAgenda_Clinicacodigo_Z ;
      private String gxTv_SdtAgenda_Agendaid_Z ;
      private String gxTv_SdtAgenda_Agendanombre_Z ;
      private String gxTv_SdtAgenda_Agendaobs_Z ;
      [NonSerialized()] private IGxDataStore dsDefault ;
      private Assembly constructorCallingAssembly ;
      private IGxContext context ;
   }

}
