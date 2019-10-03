/*
               File: LoadEventsSampleDP
        Description: Load Events Sample DP
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:3:32.86
       Program type: Callable routine
          Main DBMS: sqlserver
*/
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
using GeneXus.Procedure;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Threading;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class loadeventssampledp : GXProcedure
   {
      public loadeventssampledp( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public loadeventssampledp( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( out SdtSchedulerEvents aP0_Gxm2schedulerevents )
      {
         this.Gxm2schedulerevents = new SdtSchedulerEvents(context) ;
         initialize();
         executePrivate();
         aP0_Gxm2schedulerevents=this.Gxm2schedulerevents;
      }

      public SdtSchedulerEvents executeUdp( )
      {
         this.Gxm2schedulerevents = new SdtSchedulerEvents(context) ;
         initialize();
         executePrivate();
         aP0_Gxm2schedulerevents=this.Gxm2schedulerevents;
         return Gxm2schedulerevents ;
      }

      public void executeSubmit( out SdtSchedulerEvents aP0_Gxm2schedulerevents )
      {
         loadeventssampledp objloadeventssampledp;
         objloadeventssampledp = new loadeventssampledp();
         objloadeventssampledp.Gxm2schedulerevents = new SdtSchedulerEvents(context) ;
         objloadeventssampledp.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objloadeventssampledp);
         aP0_Gxm2schedulerevents=this.Gxm2schedulerevents;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((loadeventssampledp)stateInfo).executePrivate();
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
         /* Using cursor P00022 */
         pr_default.execute(0, new Object[] {AV6EndDate, AV5StartDate});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A230AgendaInicial = P00022_A230AgendaInicial[0] ;
            A231AgendaFinal = P00022_A231AgendaFinal[0] ;
            A56AgendaId = P00022_A56AgendaId[0] ;
            A246AgendaNombre = P00022_A246AgendaNombre[0] ;
            A232AgendaObs = P00022_A232AgendaObs[0] ;
            A41ClinicaCodigo = P00022_A41ClinicaCodigo[0] ;
            Gxm1schedulerevents_items = new SdtSchedulerEvents_event(context) ;
            Gxm2schedulerevents.gxTpr_Items.Add(Gxm1schedulerevents_items, 0);
            Gxm1schedulerevents_items.gxTpr_Id = A56AgendaId ;
            Gxm1schedulerevents_items.gxTpr_Name = A246AgendaNombre ;
            Gxm1schedulerevents_items.gxTpr_Notes = A232AgendaObs ;
            Gxm1schedulerevents_items.gxTpr_Starttime = A230AgendaInicial ;
            Gxm1schedulerevents_items.gxTpr_Endtime = A231AgendaFinal ;
            pr_default.readNext(0);
         }
         pr_default.close(0);
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
         scmdbuf = "" ;
         AV6EndDate = DateTime.MinValue ;
         AV5StartDate = DateTime.MinValue ;
         P00022_A230AgendaInicial = new DateTime[] {DateTime.MinValue} ;
         P00022_A231AgendaFinal = new DateTime[] {DateTime.MinValue} ;
         P00022_A56AgendaId = new String[] {""} ;
         P00022_A246AgendaNombre = new String[] {""} ;
         P00022_A232AgendaObs = new String[] {""} ;
         P00022_A41ClinicaCodigo = new String[] {""} ;
         A230AgendaInicial = (DateTime)(DateTime.MinValue) ;
         A231AgendaFinal = (DateTime)(DateTime.MinValue) ;
         A56AgendaId = "" ;
         A246AgendaNombre = "" ;
         A232AgendaObs = "" ;
         A41ClinicaCodigo = "" ;
         Gxm1schedulerevents_items = new SdtSchedulerEvents_event(context);
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.loadeventssampledp__default(),
            new Object[][] {
                new Object[] {
               P00022_A230AgendaInicial, P00022_A231AgendaFinal, P00022_A56AgendaId, P00022_A246AgendaNombre, P00022_A232AgendaObs, P00022_A41ClinicaCodigo
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private String scmdbuf ;
      private DateTime A230AgendaInicial ;
      private DateTime A231AgendaFinal ;
      private DateTime AV6EndDate ;
      private DateTime AV5StartDate ;
      private String A56AgendaId ;
      private String A246AgendaNombre ;
      private String A232AgendaObs ;
      private String A41ClinicaCodigo ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private DateTime[] P00022_A230AgendaInicial ;
      private DateTime[] P00022_A231AgendaFinal ;
      private String[] P00022_A56AgendaId ;
      private String[] P00022_A246AgendaNombre ;
      private String[] P00022_A232AgendaObs ;
      private String[] P00022_A41ClinicaCodigo ;
      private SdtSchedulerEvents aP0_Gxm2schedulerevents ;
      private SdtSchedulerEvents Gxm2schedulerevents ;
      private SdtSchedulerEvents_event Gxm1schedulerevents_items ;
   }

   public class loadeventssampledp__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP00022 ;
          prmP00022 = new Object[] {
          new Object[] {"@AV6EndDate",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV5StartDate",SqlDbType.DateTime,8,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00022", "SELECT [AgendaInicial], [AgendaFinal], [AgendaId], [AgendaNombre], [AgendaObs], [ClinicaCodigo] FROM [Agenda] WITH (NOLOCK) WHERE ([AgendaFinal] <= @AV6EndDate) AND ([AgendaInicial] >= @AV5StartDate) ORDER BY [ClinicaCodigo], [AgendaId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00022,100,0,false,false )
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
             case 0 :
                ((DateTime[]) buf[0])[0] = rslt.getGXDateTime(1) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDateTime(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                break;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 0 :
                stmt.SetParameter(1, (DateTime)parms[0]);
                stmt.SetParameter(2, (DateTime)parms[1]);
                break;
       }
    }

 }

}
