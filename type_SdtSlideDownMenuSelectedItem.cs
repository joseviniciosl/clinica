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
   public class SdtSlideDownMenuSelectedItem : GxUserType
   {
      public SdtSlideDownMenuSelectedItem( )
      {
         constructorCallingAssembly = Assembly.GetCallingAssembly() ;
         initialize();
      }

      public SdtSlideDownMenuSelectedItem( IGxContext context )
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
               if ( StringUtil.StrCmp2( oReader.LocalName, "ParentID") )
               {
                  gxTv_SdtSlideDownMenuSelectedItem_Parentid = (short)(NumberUtil.Val( oReader.Value, ".")) ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "SectionID") )
               {
                  gxTv_SdtSlideDownMenuSelectedItem_Sectionid = (short)(NumberUtil.Val( oReader.Value, ".")) ;
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
            sName = "SelectedItem" ;
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
         oWriter.WriteElement("ParentID", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_SdtSlideDownMenuSelectedItem_Parentid), 4, 0)));
         if ( StringUtil.StrCmp(sNameSpace, "Clinica") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Clinica");
         }
         oWriter.WriteElement("SectionID", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_SdtSlideDownMenuSelectedItem_Sectionid), 4, 0)));
         if ( StringUtil.StrCmp(sNameSpace, "Clinica") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Clinica");
         }
         oWriter.WriteEndElement();
         return  ;
      }

      public override void ToJSON( )
      {
         AddObjectProperty("ParentID", (Object)(gxTv_SdtSlideDownMenuSelectedItem_Parentid));
         AddObjectProperty("SectionID", (Object)(gxTv_SdtSlideDownMenuSelectedItem_Sectionid));
         return  ;
      }

      public short gxTpr_Parentid
      {
         get {
            return gxTv_SdtSlideDownMenuSelectedItem_Parentid ;
         }

         set {
            gxTv_SdtSlideDownMenuSelectedItem_Parentid = (short)(value) ;
         }

      }

      public void gxTv_SdtSlideDownMenuSelectedItem_Parentid_SetNull( )
      {
         gxTv_SdtSlideDownMenuSelectedItem_Parentid = 0 ;
         return  ;
      }

      public bool gxTv_SdtSlideDownMenuSelectedItem_Parentid_IsNull( )
      {
         return false ;
      }

      public short gxTpr_Sectionid
      {
         get {
            return gxTv_SdtSlideDownMenuSelectedItem_Sectionid ;
         }

         set {
            gxTv_SdtSlideDownMenuSelectedItem_Sectionid = (short)(value) ;
         }

      }

      public void gxTv_SdtSlideDownMenuSelectedItem_Sectionid_SetNull( )
      {
         gxTv_SdtSlideDownMenuSelectedItem_Sectionid = 0 ;
         return  ;
      }

      public bool gxTv_SdtSlideDownMenuSelectedItem_Sectionid_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         sTagName = "" ;
         return  ;
      }

      protected short gxTv_SdtSlideDownMenuSelectedItem_Parentid ;
      protected short gxTv_SdtSlideDownMenuSelectedItem_Sectionid ;
      protected short readOk ;
      protected short nOutParmCount ;
      protected String sTagName ;
      protected Assembly constructorCallingAssembly ;
      protected IGxContext context ;
   }

}
