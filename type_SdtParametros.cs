using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using GeneXus.Data;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using System.Runtime.Remoting;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Reflection;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   [Serializable]
   public class SdtParametros : GxUserType
   {
      public SdtParametros( )
      {
         constructorCallingAssembly = Assembly.GetCallingAssembly() ;
         initialize();
      }

      public SdtParametros( IGxContext context )
      {
         this.context = context;
         constructorCallingAssembly = Assembly.GetCallingAssembly() ;
         initialize();
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
               if ( StringUtil.StrCmp2( oReader.LocalName, "pUsuarioCodigo") )
               {
                  gxTv_SdtParametros_Pusuariocodigo = oReader.Value ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "pGrupoCodigo") )
               {
                  gxTv_SdtParametros_Pgrupocodigo = oReader.Value ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "pClinicaCodigo") )
               {
                  gxTv_SdtParametros_Pclinicacodigo = oReader.Value ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "pCajaCodigo") )
               {
                  gxTv_SdtParametros_Pcajacodigo = oReader.Value ;
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
            sName = "Parametros" ;
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
         oWriter.WriteElement("pUsuarioCodigo", StringUtil.RTrim( gxTv_SdtParametros_Pusuariocodigo));
         if ( StringUtil.StrCmp(sNameSpace, "Clinica") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Clinica");
         }
         oWriter.WriteElement("pGrupoCodigo", StringUtil.RTrim( gxTv_SdtParametros_Pgrupocodigo));
         if ( StringUtil.StrCmp(sNameSpace, "Clinica") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Clinica");
         }
         oWriter.WriteElement("pClinicaCodigo", StringUtil.RTrim( gxTv_SdtParametros_Pclinicacodigo));
         if ( StringUtil.StrCmp(sNameSpace, "Clinica") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Clinica");
         }
         oWriter.WriteElement("pCajaCodigo", StringUtil.RTrim( gxTv_SdtParametros_Pcajacodigo));
         if ( StringUtil.StrCmp(sNameSpace, "Clinica") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Clinica");
         }
         oWriter.WriteEndElement();
         return  ;
      }

      public override void ToJSON( )
      {
         AddObjectProperty("pUsuarioCodigo", (Object)(gxTv_SdtParametros_Pusuariocodigo));
         AddObjectProperty("pGrupoCodigo", (Object)(gxTv_SdtParametros_Pgrupocodigo));
         AddObjectProperty("pClinicaCodigo", (Object)(gxTv_SdtParametros_Pclinicacodigo));
         AddObjectProperty("pCajaCodigo", (Object)(gxTv_SdtParametros_Pcajacodigo));
         return  ;
      }

      public String gxTpr_Pusuariocodigo
      {
         get {
            return gxTv_SdtParametros_Pusuariocodigo ;
         }

         set {
            gxTv_SdtParametros_Pusuariocodigo = (String)(value) ;
         }

      }

      public void gxTv_SdtParametros_Pusuariocodigo_SetNull( )
      {
         gxTv_SdtParametros_Pusuariocodigo = "" ;
         return  ;
      }

      public bool gxTv_SdtParametros_Pusuariocodigo_IsNull( )
      {
         return false ;
      }

      public String gxTpr_Pgrupocodigo
      {
         get {
            return gxTv_SdtParametros_Pgrupocodigo ;
         }

         set {
            gxTv_SdtParametros_Pgrupocodigo = (String)(value) ;
         }

      }

      public void gxTv_SdtParametros_Pgrupocodigo_SetNull( )
      {
         gxTv_SdtParametros_Pgrupocodigo = "" ;
         return  ;
      }

      public bool gxTv_SdtParametros_Pgrupocodigo_IsNull( )
      {
         return false ;
      }

      public String gxTpr_Pclinicacodigo
      {
         get {
            return gxTv_SdtParametros_Pclinicacodigo ;
         }

         set {
            gxTv_SdtParametros_Pclinicacodigo = (String)(value) ;
         }

      }

      public void gxTv_SdtParametros_Pclinicacodigo_SetNull( )
      {
         gxTv_SdtParametros_Pclinicacodigo = "" ;
         return  ;
      }

      public bool gxTv_SdtParametros_Pclinicacodigo_IsNull( )
      {
         return false ;
      }

      public String gxTpr_Pcajacodigo
      {
         get {
            return gxTv_SdtParametros_Pcajacodigo ;
         }

         set {
            gxTv_SdtParametros_Pcajacodigo = (String)(value) ;
         }

      }

      public void gxTv_SdtParametros_Pcajacodigo_SetNull( )
      {
         gxTv_SdtParametros_Pcajacodigo = "" ;
         return  ;
      }

      public bool gxTv_SdtParametros_Pcajacodigo_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtParametros_Pusuariocodigo = "" ;
         gxTv_SdtParametros_Pgrupocodigo = "" ;
         gxTv_SdtParametros_Pclinicacodigo = "" ;
         gxTv_SdtParametros_Pcajacodigo = "" ;
         sTagName = "" ;
         return  ;
      }

      protected short readOk ;
      protected short nOutParmCount ;
      protected String sTagName ;
      protected String gxTv_SdtParametros_Pusuariocodigo ;
      protected String gxTv_SdtParametros_Pgrupocodigo ;
      protected String gxTv_SdtParametros_Pclinicacodigo ;
      protected String gxTv_SdtParametros_Pcajacodigo ;
      protected Assembly constructorCallingAssembly ;
      protected IGxContext context ;
   }

}
