/*
               File: SchedulerRequestHandler
        Description: Scheduler Request Handler
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:3:39.41
       Program type: Main program
          Main DBMS: sqlserver
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using GeneXus.Data;
using com.genexus;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using System.Runtime.Remoting;
using GeneXus.WebControls;
using GeneXus.Http;
using GeneXus.Procedure;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using GeneXus.Http.Server;
using System.Threading;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class aschedulerrequesthandler : GXWebProcedure, System.Web.SessionState.IRequiresSessionState
   {
      public override void webExecute( )
      {
         context.SetTheme("Fantastic");
         initialize();
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.GetCookie( "GX_SESSION_ID"))) )
         {
            gxcookieaux = context.SetCookie( "GX_SESSION_ID", Crypto.Encrypt64( Crypto.GetEncryptionKey( ), Crypto.GetServerKey( )), "", (DateTime)(DateTime.MinValue), "", 0) ;
         }
         GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( )) ;
         if ( nGotPars == 0 )
         {
            entryPointCalled = false ;
            gxfirstwebparm = GetNextPar( ) ;
         }
         if ( GxWebError == 0 )
         {
            executePrivate();
         }
         cleanup();
      }

      public aschedulerrequesthandler( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public aschedulerrequesthandler( IGxContext context )
      {
         this.context = context;
         IsMain = false;
      }

      public void release( )
      {
      }

      public void execute( )
      {
         initialize();
         executePrivate();
      }

      public void executeSubmit( )
      {
         aschedulerrequesthandler objaschedulerrequesthandler;
         objaschedulerrequesthandler = new aschedulerrequesthandler();
         objaschedulerrequesthandler.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objaschedulerrequesthandler);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((aschedulerrequesthandler)stateInfo).executePrivate();
         }
         catch ( Exception e )
         {
            GXUtil.SaveToEventLog( "Design", e);
            throw e ;
         }
      }

      void executePrivate( )
      {
         /* GeneXus formulas */
         /* Output device settings */
         AV21queryString = AV20httpRequest.QueryString ;
         if ( ( StringUtil.StringSearch( AV21queryString, "&from=", 1) > 0 ) && ( StringUtil.StringSearch( AV21queryString, "&to=", 1) > 0 ) )
         {
            AV10callbackIndex = (short)(StringUtil.StringSearch( AV21queryString, "&callback=", 1)) ;
            AV8auxIndex = (short)(StringUtil.StringSearch( AV21queryString, "&", AV10callbackIndex+10)) ;
            AV9callback = StringUtil.Substring( AV21queryString, AV10callbackIndex+10, AV8auxIndex-(AV10callbackIndex+10)) ;
            AV12fromIndex = (short)(StringUtil.StringSearch( AV21queryString, "&from=", 1)) ;
            AV8auxIndex = (short)(StringUtil.StringSearch( AV21queryString, "&", AV12fromIndex+6)) ;
            AV11from = StringUtil.Substring( AV21queryString, AV12fromIndex+6, AV8auxIndex-(AV12fromIndex+6)) ;
            AV15toIndex = (short)(StringUtil.StringSearch( AV21queryString, "&to=", 1)) ;
            AV14to = StringUtil.Substring( AV21queryString, AV15toIndex+4, StringUtil.Len( AV21queryString)) ;
            AV19fromCollection = GxRegex.Split(AV11from,"-") ;
            AV22toCollection = GxRegex.Split(AV14to,"-") ;
            AV16dateFrom = context.localUtil.YMDToD( (int)(NumberUtil.Val( AV19fromCollection.GetString(1), ".")), (int)(NumberUtil.Val( AV19fromCollection.GetString(2), ".")), (int)(NumberUtil.Val( AV19fromCollection.GetString(3), "."))) ;
            AV17dateTo = context.localUtil.YMDToD( (int)(NumberUtil.Val( AV22toCollection.GetString(1), ".")), (int)(NumberUtil.Val( AV22toCollection.GetString(2), ".")), (int)(NumberUtil.Val( AV22toCollection.GetString(3), "."))) ;
            try {
               args = new Object[] {(DateTime)AV16dateFrom,(DateTime)AV17dateTo,(SdtSchedulerEvents)AV18events} ;
               ClassLoader.WebExecute(AV9callback,"GeneXus.Programs." +AV9callback.ToLower(), new Object[] {context }, "execute", args);
               if ( ( args != null ) && ( args.Length == 3 ) )
               {
                  AV16dateFrom = (DateTime)(args[0]) ;
                  AV17dateTo = (DateTime)(args[1]) ;
                  AV18events = (SdtSchedulerEvents)(args[2]) ;
               }
            }
            catch (GxClassLoaderException) {
               if ( AV9callback .IndexOf(".") == -1)
                  context.wjLoc = formatLink(AV9callback+".aspx") + "?" + UrlEncode(DateTimeUtil.FormatDateParm(AV16dateFrom)) + "," + UrlEncode(DateTimeUtil.FormatDateParm(AV17dateTo)) ;
               else
                  context.wjLoc = formatLink(AV9callback) + "?" + UrlEncode(DateTimeUtil.FormatDateParm(AV16dateFrom)) + "," + UrlEncode(DateTimeUtil.FormatDateParm(AV17dateTo)) ;

            }
         }
         if ( ! context.isAjaxRequest( ) )
         {
            AV13httpResponse.AppendHeader("Content-Type", "text/xml");
         }
         AV13httpResponse.AddString(AV18events.ToXml(false, "data", ""));
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) )
         {
            context.Redirect( context.wjLoc );
            context.wjLoc = "" ;
         }
         this.cleanup();
      }

      protected void cleanup( )
      {
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
         exitApplication();
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         GXKey = "" ;
         gxfirstwebparm = "" ;
         AV21queryString = "" ;
         AV20httpRequest = new GxHttpRequest( context);
         AV9callback = "" ;
         AV11from = "" ;
         AV14to = "" ;
         AV19fromCollection = new GxSimpleCollection();
         AV22toCollection = new GxSimpleCollection();
         AV16dateFrom = DateTime.MinValue ;
         AV17dateTo = DateTime.MinValue ;
         AV18events = new SdtSchedulerEvents(context);
         GXt_char1 = "" ;
         AV13httpResponse = new GxHttpResponse( context);
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short gxcookieaux ;
      private short nGotPars ;
      private short GxWebError ;
      private short AV10callbackIndex ;
      private short AV8auxIndex ;
      private short AV12fromIndex ;
      private short AV15toIndex ;
      private String GXKey ;
      private String gxfirstwebparm ;
      private String AV21queryString ;
      private String AV9callback ;
      private String AV11from ;
      private String AV14to ;
      private String GXt_char1 ;
      private DateTime AV16dateFrom ;
      private DateTime AV17dateTo ;
      private bool entryPointCalled ;
      private Object[] args ;
      private GxHttpRequest AV20httpRequest ;
      private GxHttpResponse AV13httpResponse ;
      [ObjectCollection(ItemType=typeof( String ))]
      private IGxCollection AV19fromCollection ;
      [ObjectCollection(ItemType=typeof( String ))]
      private IGxCollection AV22toCollection ;
      private SdtSchedulerEvents AV18events ;
   }

}
