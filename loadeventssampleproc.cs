/*
               File: LoadEventsSampleProc
        Description: Stub for LoadEventsSampleProc
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:9:59.81
       Program type: Callable routine
          Main DBMS: sqlserver
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using System.Web.Services.Protocols;
using System.Web.Services;
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
using GeneXus.Procedure;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Threading;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class loadeventssampleproc : GXProcedure
   {
      public loadeventssampleproc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public loadeventssampleproc( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( out SdtSchedulerEvents aP0_events )
      {
         this.AV2events = new SdtSchedulerEvents(context) ;
         initialize();
         executePrivate();
         aP0_events=this.AV2events;
      }

      public SdtSchedulerEvents executeUdp( )
      {
         this.AV2events = new SdtSchedulerEvents(context) ;
         initialize();
         executePrivate();
         aP0_events=this.AV2events;
         return AV2events ;
      }

      public void executeSubmit( out SdtSchedulerEvents aP0_events )
      {
         loadeventssampleproc objloadeventssampleproc;
         objloadeventssampleproc = new loadeventssampleproc();
         objloadeventssampleproc.AV2events = new SdtSchedulerEvents(context) ;
         objloadeventssampleproc.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objloadeventssampleproc);
         aP0_events=this.AV2events;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((loadeventssampleproc)stateInfo).executePrivate();
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
         args = new Object[] {(SdtSchedulerEvents)AV2events} ;
         ClassLoader.Execute("aloadeventssampleproc","GeneXus.Programs.aloadeventssampleproc", new Object[] {context }, "execute", args);
         if ( ( args != null ) && ( args.Length == 1 ) )
         {
            AV2events = (SdtSchedulerEvents)(args[0]) ;
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
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private IGxDataStore dsDefault ;
      private Object[] args ;
      private SdtSchedulerEvents aP0_events ;
      private SdtSchedulerEvents AV2events ;
   }

}
