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
   public class SdtSlideDownMenuData_SlideDownMenuDataItem : GxUserType
   {
      public SdtSlideDownMenuData_SlideDownMenuDataItem( )
      {
         constructorCallingAssembly = Assembly.GetCallingAssembly() ;
         initialize();
      }

      public SdtSlideDownMenuData_SlideDownMenuDataItem( IGxContext context )
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
                  gxTv_SdtSlideDownMenuData_SlideDownMenuDataItem_Parentid = (short)(NumberUtil.Val( oReader.Value, ".")) ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "ParentTitle") )
               {
                  gxTv_SdtSlideDownMenuData_SlideDownMenuDataItem_Parenttitle = oReader.Value ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "ParentDescription") )
               {
                  gxTv_SdtSlideDownMenuData_SlideDownMenuDataItem_Parentdescription = oReader.Value ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp2( oReader.LocalName, "Sections") )
               {
                  if ( gxTv_SdtSlideDownMenuData_SlideDownMenuDataItem_Sections == null )
                  {
                     gxTv_SdtSlideDownMenuData_SlideDownMenuDataItem_Sections = new GxObjectCollection( context, "SlideDownMenuData.SlideDownMenuDataItem.SectionsItem", "", "SdtSlideDownMenuData_SlideDownMenuDataItem_SectionsItem", "GeneXus.Programs");
                  }
                  if ( oReader.IsSimple == 0 )
                  {
                     GXSoapError = gxTv_SdtSlideDownMenuData_SlideDownMenuDataItem_Sections.readxmlcollection(oReader, "Sections", "SectionsItem") ;
                  }
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
            sName = "SlideDownMenuData.SlideDownMenuDataItem" ;
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
         oWriter.WriteElement("ParentID", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_SdtSlideDownMenuData_SlideDownMenuDataItem_Parentid), 4, 0)));
         if ( StringUtil.StrCmp(sNameSpace, "Clinica") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Clinica");
         }
         oWriter.WriteElement("ParentTitle", StringUtil.RTrim( gxTv_SdtSlideDownMenuData_SlideDownMenuDataItem_Parenttitle));
         if ( StringUtil.StrCmp(sNameSpace, "Clinica") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Clinica");
         }
         oWriter.WriteElement("ParentDescription", StringUtil.RTrim( gxTv_SdtSlideDownMenuData_SlideDownMenuDataItem_Parentdescription));
         if ( StringUtil.StrCmp(sNameSpace, "Clinica") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Clinica");
         }
         if ( gxTv_SdtSlideDownMenuData_SlideDownMenuDataItem_Sections != null )
         {
            String sNameSpace1 ;
            if ( StringUtil.StrCmp(sNameSpace, "Clinica") == 0 )
            {
               sNameSpace1 = "[*:nosend]" + "Clinica" ;
            }
            else
            {
               sNameSpace1 = "Clinica" ;
            }
            gxTv_SdtSlideDownMenuData_SlideDownMenuDataItem_Sections.writexmlcollection(oWriter, "Sections", sNameSpace1, "SectionsItem", sNameSpace1);
         }
         oWriter.WriteEndElement();
         return  ;
      }

      public override void ToJSON( )
      {
         AddObjectProperty("ParentID", (Object)(gxTv_SdtSlideDownMenuData_SlideDownMenuDataItem_Parentid));
         AddObjectProperty("ParentTitle", (Object)(gxTv_SdtSlideDownMenuData_SlideDownMenuDataItem_Parenttitle));
         AddObjectProperty("ParentDescription", (Object)(gxTv_SdtSlideDownMenuData_SlideDownMenuDataItem_Parentdescription));
         if ( gxTv_SdtSlideDownMenuData_SlideDownMenuDataItem_Sections != null )
         {
            AddObjectProperty("Sections", (Object)(gxTv_SdtSlideDownMenuData_SlideDownMenuDataItem_Sections));
         }
         return  ;
      }

      public short gxTpr_Parentid
      {
         get {
            return gxTv_SdtSlideDownMenuData_SlideDownMenuDataItem_Parentid ;
         }

         set {
            gxTv_SdtSlideDownMenuData_SlideDownMenuDataItem_Parentid = (short)(value) ;
         }

      }

      public void gxTv_SdtSlideDownMenuData_SlideDownMenuDataItem_Parentid_SetNull( )
      {
         gxTv_SdtSlideDownMenuData_SlideDownMenuDataItem_Parentid = 0 ;
         return  ;
      }

      public bool gxTv_SdtSlideDownMenuData_SlideDownMenuDataItem_Parentid_IsNull( )
      {
         return false ;
      }

      public String gxTpr_Parenttitle
      {
         get {
            return gxTv_SdtSlideDownMenuData_SlideDownMenuDataItem_Parenttitle ;
         }

         set {
            gxTv_SdtSlideDownMenuData_SlideDownMenuDataItem_Parenttitle = (String)(value) ;
         }

      }

      public void gxTv_SdtSlideDownMenuData_SlideDownMenuDataItem_Parenttitle_SetNull( )
      {
         gxTv_SdtSlideDownMenuData_SlideDownMenuDataItem_Parenttitle = "" ;
         return  ;
      }

      public bool gxTv_SdtSlideDownMenuData_SlideDownMenuDataItem_Parenttitle_IsNull( )
      {
         return false ;
      }

      public String gxTpr_Parentdescription
      {
         get {
            return gxTv_SdtSlideDownMenuData_SlideDownMenuDataItem_Parentdescription ;
         }

         set {
            gxTv_SdtSlideDownMenuData_SlideDownMenuDataItem_Parentdescription = (String)(value) ;
         }

      }

      public void gxTv_SdtSlideDownMenuData_SlideDownMenuDataItem_Parentdescription_SetNull( )
      {
         gxTv_SdtSlideDownMenuData_SlideDownMenuDataItem_Parentdescription = "" ;
         return  ;
      }

      public bool gxTv_SdtSlideDownMenuData_SlideDownMenuDataItem_Parentdescription_IsNull( )
      {
         return false ;
      }

      public IGxCollection gxTpr_Sections
      {
         get {
            if ( gxTv_SdtSlideDownMenuData_SlideDownMenuDataItem_Sections == null )
            {
               gxTv_SdtSlideDownMenuData_SlideDownMenuDataItem_Sections = new GxObjectCollection( context, "SlideDownMenuData.SlideDownMenuDataItem.SectionsItem", "", "SdtSlideDownMenuData_SlideDownMenuDataItem_SectionsItem", "GeneXus.Programs");
            }
            return gxTv_SdtSlideDownMenuData_SlideDownMenuDataItem_Sections ;
         }

         set {
            gxTv_SdtSlideDownMenuData_SlideDownMenuDataItem_Sections = value ;
         }

      }

      public void gxTv_SdtSlideDownMenuData_SlideDownMenuDataItem_Sections_SetNull( )
      {
         gxTv_SdtSlideDownMenuData_SlideDownMenuDataItem_Sections = null ;
         return  ;
      }

      public bool gxTv_SdtSlideDownMenuData_SlideDownMenuDataItem_Sections_IsNull( )
      {
         if ( gxTv_SdtSlideDownMenuData_SlideDownMenuDataItem_Sections == null )
         {
            return true ;
         }
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtSlideDownMenuData_SlideDownMenuDataItem_Parenttitle = "" ;
         gxTv_SdtSlideDownMenuData_SlideDownMenuDataItem_Parentdescription = "" ;
         sTagName = "" ;
         return  ;
      }

      protected short gxTv_SdtSlideDownMenuData_SlideDownMenuDataItem_Parentid ;
      protected short readOk ;
      protected short nOutParmCount ;
      protected String gxTv_SdtSlideDownMenuData_SlideDownMenuDataItem_Parenttitle ;
      protected String gxTv_SdtSlideDownMenuData_SlideDownMenuDataItem_Parentdescription ;
      protected String sTagName ;
      protected Assembly constructorCallingAssembly ;
      protected IGxContext context ;
      [ObjectCollection(ItemType=typeof( SdtSlideDownMenuData_SlideDownMenuDataItem_SectionsItem ))]
      protected IGxCollection gxTv_SdtSlideDownMenuData_SlideDownMenuDataItem_Sections=null ;
   }

}
