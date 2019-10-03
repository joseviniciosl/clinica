/*
               File: AgendaConversion
        Description: Conversion for table Agenda
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 4/10/2019 12:10:43.81
       Program type: Callable routine
          Main DBMS: sqlserver
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using GeneXus.Reorg;
using System.Threading;
using GeneXus.Programs;
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
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class agendaconversion : GXProcedure
   {
      public agendaconversion( )
      {
         this.DisconnectAtCleanup = true;
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public agendaconversion( IGxContext context )
      {
         this.DisconnectAtCleanup = true;
         context = context.UtlClone();
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
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
         agendaconversion objagendaconversion;
         objagendaconversion = new agendaconversion();
         objagendaconversion.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objagendaconversion);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((agendaconversion)stateInfo).executePrivate();
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
         /* Using cursor AGENDACONV2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A232AgendaObs = AGENDACONV2_A232AgendaObs[0] ;
            A231AgendaFinal = AGENDACONV2_A231AgendaFinal[0] ;
            A230AgendaInicial = AGENDACONV2_A230AgendaInicial[0] ;
            A41ClinicaCodigo = AGENDACONV2_A41ClinicaCodigo[0] ;
            A56AgendaId = AGENDACONV2_A56AgendaId[0] ;
            A40000GXC1 = AGENDACONV2_A40000GXC1[0] ;
            /*
               INSERT RECORD ON TABLE GXA0057

            */
            AV2ClinicaCodigo = A41ClinicaCodigo ;
            AV3AgendaId = A40000GXC1 ;
            AV4AgendaInicial = A230AgendaInicial ;
            AV5AgendaFinal = A231AgendaFinal ;
            AV6AgendaObs = A232AgendaObs ;
            AV7AgendaNombre = " " ;
            /* Using cursor AGENDACONV3 */
            pr_default.execute(1, new Object[] {AV2ClinicaCodigo, AV3AgendaId, AV4AgendaInicial, AV5AgendaFinal, AV6AgendaObs, AV7AgendaNombre});
            pr_default.close(1);
            if ( (pr_default.getStatus(1) == 1) )
            {
               context.Gx_err = 1 ;
               Gx_emsg = (String)(GXResourceManager.GetMessage("GXM_noupdate")) ;
            }
            else
            {
               context.Gx_err = 0 ;
               Gx_emsg = "" ;
            }
            /* End Insert */
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
         AGENDACONV2_A232AgendaObs = new String[] {""} ;
         AGENDACONV2_A231AgendaFinal = new DateTime[] {DateTime.MinValue} ;
         AGENDACONV2_A230AgendaInicial = new DateTime[] {DateTime.MinValue} ;
         AGENDACONV2_A41ClinicaCodigo = new String[] {""} ;
         AGENDACONV2_A56AgendaId = new int[1] ;
         AGENDACONV2_A40000GXC1 = new String[] {""} ;
         A232AgendaObs = "" ;
         A231AgendaFinal = (DateTime)(DateTime.MinValue) ;
         A230AgendaInicial = (DateTime)(DateTime.MinValue) ;
         A41ClinicaCodigo = "" ;
         A40000GXC1 = "" ;
         AV2ClinicaCodigo = "" ;
         AV3AgendaId = "" ;
         AV4AgendaInicial = (DateTime)(DateTime.MinValue) ;
         AV5AgendaFinal = (DateTime)(DateTime.MinValue) ;
         AV6AgendaObs = "" ;
         AV7AgendaNombre = "" ;
         Gx_emsg = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.agendaconversion__default(),
            new Object[][] {
                new Object[] {
               AGENDACONV2_A232AgendaObs, AGENDACONV2_A231AgendaFinal, AGENDACONV2_A230AgendaInicial, AGENDACONV2_A41ClinicaCodigo, AGENDACONV2_A56AgendaId, AGENDACONV2_A40000GXC1
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private int A56AgendaId ;
      private int GIGXA0057 ;
      private String scmdbuf ;
      private String Gx_emsg ;
      private DateTime A231AgendaFinal ;
      private DateTime A230AgendaInicial ;
      private DateTime AV4AgendaInicial ;
      private DateTime AV5AgendaFinal ;
      private String A232AgendaObs ;
      private String A41ClinicaCodigo ;
      private String A40000GXC1 ;
      private String AV2ClinicaCodigo ;
      private String AV3AgendaId ;
      private String AV6AgendaObs ;
      private String AV7AgendaNombre ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] AGENDACONV2_A232AgendaObs ;
      private DateTime[] AGENDACONV2_A231AgendaFinal ;
      private DateTime[] AGENDACONV2_A230AgendaInicial ;
      private String[] AGENDACONV2_A41ClinicaCodigo ;
      private int[] AGENDACONV2_A56AgendaId ;
      private String[] AGENDACONV2_A40000GXC1 ;
   }

   public class agendaconversion__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new UpdateCursor(def[1])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmAGENDACONV2 ;
          prmAGENDACONV2 = new Object[] {
          } ;
          Object[] prmAGENDACONV3 ;
          prmAGENDACONV3 = new Object[] {
          new Object[] {"@AV2ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV3AgendaId",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV4AgendaInicial",SqlDbType.DateTime,8,5} ,
          new Object[] {"@AV5AgendaFinal",SqlDbType.DateTime,8,5} ,
          new Object[] {"@AV6AgendaObs",SqlDbType.VarChar,600,0} ,
          new Object[] {"@AV7AgendaNombre",SqlDbType.VarChar,30,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("AGENDACONV2", "SELECT [AgendaObs], [AgendaFinal], [AgendaInicial], [ClinicaCodigo], [AgendaId], CONVERT( char(9), CAST([AgendaId] AS decimal(9,0))) AS GXC1 FROM [Agenda] ORDER BY [ClinicaCodigo], [AgendaId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmAGENDACONV2,100,0,true,false )
             ,new CursorDef("AGENDACONV3", "INSERT INTO [GXA0057] ([ClinicaCodigo], [AgendaId], [AgendaInicial], [AgendaFinal], [AgendaObs], [AgendaNombre]) VALUES (@AV2ClinicaCodigo, @AV3AgendaId, @AV4AgendaInicial, @AV5AgendaFinal, @AV6AgendaObs, @AV7AgendaNombre)", GxErrorMask.GX_NOMASK,prmAGENDACONV3)
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
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDateTime(2) ;
                ((DateTime[]) buf[2])[0] = rslt.getGXDateTime(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((int[]) buf[4])[0] = rslt.getInt(5) ;
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
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (DateTime)parms[2]);
                stmt.SetParameter(4, (DateTime)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                break;
       }
    }

 }

}
