/*
               File: TipoPartidaConversion
        Description: Conversion for table TipoPartida
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 4/1/2019 14:43:26.72
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
   public class tipopartidaconversion : GXProcedure
   {
      public tipopartidaconversion( )
      {
         this.DisconnectAtCleanup = true;
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public tipopartidaconversion( IGxContext context )
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
         tipopartidaconversion objtipopartidaconversion;
         objtipopartidaconversion = new tipopartidaconversion();
         objtipopartidaconversion.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objtipopartidaconversion);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((tipopartidaconversion)stateInfo).executePrivate();
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
         /* Using cursor TIPOPARTID2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A203TipoParEstado = TIPOPARTID2_A203TipoParEstado[0] ;
            A202TipoParMayoriza = TIPOPARTID2_A202TipoParMayoriza[0] ;
            A201TipoParAuxiliar = TIPOPARTID2_A201TipoParAuxiliar[0] ;
            A200TipoParNombre = TIPOPARTID2_A200TipoParNombre[0] ;
            A199TipoParCodigo = TIPOPARTID2_A199TipoParCodigo[0] ;
            A41ClinicaCodigo = TIPOPARTID2_A41ClinicaCodigo[0] ;
            A40000GXC1 = TIPOPARTID2_A40000GXC1[0] ;
            /*
               INSERT RECORD ON TABLE GXA0051

            */
            AV2ClinicaCodigo = A40000GXC1 ;
            AV3TipoParCodigo = A199TipoParCodigo ;
            AV4TipoParNombre = A200TipoParNombre ;
            AV5TipoParAuxiliar = A201TipoParAuxiliar ;
            AV6TipoParMayoriza = A202TipoParMayoriza ;
            AV7TipoParEstado = A203TipoParEstado ;
            /* Using cursor TIPOPARTID3 */
            pr_default.execute(1, new Object[] {AV2ClinicaCodigo, AV3TipoParCodigo, AV4TipoParNombre, AV5TipoParAuxiliar, AV6TipoParMayoriza, AV7TipoParEstado});
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
         TIPOPARTID2_A203TipoParEstado = new short[1] ;
         TIPOPARTID2_A202TipoParMayoriza = new short[1] ;
         TIPOPARTID2_A201TipoParAuxiliar = new short[1] ;
         TIPOPARTID2_A200TipoParNombre = new String[] {""} ;
         TIPOPARTID2_A199TipoParCodigo = new String[] {""} ;
         TIPOPARTID2_A41ClinicaCodigo = new String[] {""} ;
         TIPOPARTID2_A40000GXC1 = new int[1] ;
         A200TipoParNombre = "" ;
         A199TipoParCodigo = "" ;
         A41ClinicaCodigo = "" ;
         AV3TipoParCodigo = "" ;
         AV4TipoParNombre = "" ;
         Gx_emsg = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.tipopartidaconversion__default(),
            new Object[][] {
                new Object[] {
               TIPOPARTID2_A203TipoParEstado, TIPOPARTID2_A202TipoParMayoriza, TIPOPARTID2_A201TipoParAuxiliar, TIPOPARTID2_A200TipoParNombre, TIPOPARTID2_A199TipoParCodigo, TIPOPARTID2_A41ClinicaCodigo, TIPOPARTID2_A40000GXC1
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short A203TipoParEstado ;
      private short A202TipoParMayoriza ;
      private short A201TipoParAuxiliar ;
      private short AV5TipoParAuxiliar ;
      private short AV6TipoParMayoriza ;
      private short AV7TipoParEstado ;
      private int A40000GXC1 ;
      private int GIGXA0051 ;
      private int AV2ClinicaCodigo ;
      private String scmdbuf ;
      private String Gx_emsg ;
      private String A200TipoParNombre ;
      private String A199TipoParCodigo ;
      private String A41ClinicaCodigo ;
      private String AV3TipoParCodigo ;
      private String AV4TipoParNombre ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] TIPOPARTID2_A203TipoParEstado ;
      private short[] TIPOPARTID2_A202TipoParMayoriza ;
      private short[] TIPOPARTID2_A201TipoParAuxiliar ;
      private String[] TIPOPARTID2_A200TipoParNombre ;
      private String[] TIPOPARTID2_A199TipoParCodigo ;
      private String[] TIPOPARTID2_A41ClinicaCodigo ;
      private int[] TIPOPARTID2_A40000GXC1 ;
   }

   public class tipopartidaconversion__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmTIPOPARTID2 ;
          prmTIPOPARTID2 = new Object[] {
          } ;
          Object[] prmTIPOPARTID3 ;
          prmTIPOPARTID3 = new Object[] {
          new Object[] {"@AV2ClinicaCodigo",SqlDbType.Int,9,0} ,
          new Object[] {"@AV3TipoParCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV4TipoParNombre",SqlDbType.VarChar,30,0} ,
          new Object[] {"@AV5TipoParAuxiliar",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@AV6TipoParMayoriza",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@AV7TipoParEstado",SqlDbType.SmallInt,1,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("TIPOPARTID2", "SELECT [TipoParEstado], [TipoParMayoriza], [TipoParAuxiliar], [TipoParNombre], [TipoParCodigo], [ClinicaCodigo], CASE  WHEN ISNUMERIC([ClinicaCodigo])=0 THEN 0 ELSE CONVERT( DECIMAL(28,14), [ClinicaCodigo]) END AS GXC1 FROM [TipoPartida] ORDER BY [ClinicaCodigo], [TipoParCodigo] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmTIPOPARTID2,100,0,true,false )
             ,new CursorDef("TIPOPARTID3", "INSERT INTO [GXA0051] ([ClinicaCodigo], [TipoParCodigo], [TipoParNombre], [TipoParAuxiliar], [TipoParMayoriza], [TipoParEstado]) VALUES (@AV2ClinicaCodigo, @AV3TipoParCodigo, @AV4TipoParNombre, @AV5TipoParAuxiliar, @AV6TipoParMayoriza, @AV7TipoParEstado)", GxErrorMask.GX_NOMASK,prmTIPOPARTID3)
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
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((int[]) buf[6])[0] = rslt.getInt(7) ;
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
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                break;
       }
    }

 }

}
