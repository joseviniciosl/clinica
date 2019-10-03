/*
               File: CargoConversion
        Description: Conversion for table Cargo
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 4/1/2019 14:43:23.55
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
   public class cargoconversion : GXProcedure
   {
      public cargoconversion( )
      {
         this.DisconnectAtCleanup = true;
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public cargoconversion( IGxContext context )
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
         cargoconversion objcargoconversion;
         objcargoconversion = new cargoconversion();
         objcargoconversion.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objcargoconversion);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((cargoconversion)stateInfo).executePrivate();
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
         /* Using cursor CARGOCONVE2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A166CargoEstado = CARGOCONVE2_A166CargoEstado[0] ;
            A164CargoCantidad = CARGOCONVE2_A164CargoCantidad[0] ;
            A163CargoPrecio = CARGOCONVE2_A163CargoPrecio[0] ;
            A30ArticuloCodigo = CARGOCONVE2_A30ArticuloCodigo[0] ;
            A162CargoId = CARGOCONVE2_A162CargoId[0] ;
            A91ConsultaId = CARGOCONVE2_A91ConsultaId[0] ;
            A41ClinicaCodigo = CARGOCONVE2_A41ClinicaCodigo[0] ;
            A40000GXC1 = CARGOCONVE2_A40000GXC1[0] ;
            /*
               INSERT RECORD ON TABLE GXA0045

            */
            AV2ClinicaCodigo = A40000GXC1 ;
            AV3ConsultaId = A91ConsultaId ;
            AV4CargoId = A162CargoId ;
            AV5ArticuloCodigo = A30ArticuloCodigo ;
            AV6CargoPrecio = A163CargoPrecio ;
            AV7CargoCantidad = A164CargoCantidad ;
            AV8CargoEstado = A166CargoEstado ;
            /* Using cursor CARGOCONVE3 */
            pr_default.execute(1, new Object[] {AV2ClinicaCodigo, AV3ConsultaId, AV4CargoId, AV5ArticuloCodigo, AV6CargoPrecio, AV7CargoCantidad, AV8CargoEstado});
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
         CARGOCONVE2_A166CargoEstado = new short[1] ;
         CARGOCONVE2_A164CargoCantidad = new decimal[1] ;
         CARGOCONVE2_A163CargoPrecio = new decimal[1] ;
         CARGOCONVE2_A30ArticuloCodigo = new String[] {""} ;
         CARGOCONVE2_A162CargoId = new int[1] ;
         CARGOCONVE2_A91ConsultaId = new int[1] ;
         CARGOCONVE2_A41ClinicaCodigo = new String[] {""} ;
         CARGOCONVE2_A40000GXC1 = new int[1] ;
         A30ArticuloCodigo = "" ;
         A41ClinicaCodigo = "" ;
         AV5ArticuloCodigo = "" ;
         Gx_emsg = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.cargoconversion__default(),
            new Object[][] {
                new Object[] {
               CARGOCONVE2_A166CargoEstado, CARGOCONVE2_A164CargoCantidad, CARGOCONVE2_A163CargoPrecio, CARGOCONVE2_A30ArticuloCodigo, CARGOCONVE2_A162CargoId, CARGOCONVE2_A91ConsultaId, CARGOCONVE2_A41ClinicaCodigo, CARGOCONVE2_A40000GXC1
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short A166CargoEstado ;
      private short AV8CargoEstado ;
      private int A162CargoId ;
      private int A91ConsultaId ;
      private int A40000GXC1 ;
      private int GIGXA0045 ;
      private int AV2ClinicaCodigo ;
      private int AV3ConsultaId ;
      private int AV4CargoId ;
      private decimal A164CargoCantidad ;
      private decimal A163CargoPrecio ;
      private decimal AV6CargoPrecio ;
      private decimal AV7CargoCantidad ;
      private String scmdbuf ;
      private String Gx_emsg ;
      private String A30ArticuloCodigo ;
      private String A41ClinicaCodigo ;
      private String AV5ArticuloCodigo ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] CARGOCONVE2_A166CargoEstado ;
      private decimal[] CARGOCONVE2_A164CargoCantidad ;
      private decimal[] CARGOCONVE2_A163CargoPrecio ;
      private String[] CARGOCONVE2_A30ArticuloCodigo ;
      private int[] CARGOCONVE2_A162CargoId ;
      private int[] CARGOCONVE2_A91ConsultaId ;
      private String[] CARGOCONVE2_A41ClinicaCodigo ;
      private int[] CARGOCONVE2_A40000GXC1 ;
   }

   public class cargoconversion__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmCARGOCONVE2 ;
          prmCARGOCONVE2 = new Object[] {
          } ;
          Object[] prmCARGOCONVE3 ;
          prmCARGOCONVE3 = new Object[] {
          new Object[] {"@AV2ClinicaCodigo",SqlDbType.Int,9,0} ,
          new Object[] {"@AV3ConsultaId",SqlDbType.Int,9,0} ,
          new Object[] {"@AV4CargoId",SqlDbType.Int,9,0} ,
          new Object[] {"@AV5ArticuloCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV6CargoPrecio",SqlDbType.Decimal,17,2} ,
          new Object[] {"@AV7CargoCantidad",SqlDbType.Decimal,17,2} ,
          new Object[] {"@AV8CargoEstado",SqlDbType.SmallInt,1,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("CARGOCONVE2", "SELECT [CargoEstado], [CargoCantidad], [CargoPrecio], [ArticuloCodigo], [CargoId], [ConsultaId], [ClinicaCodigo], CASE  WHEN ISNUMERIC([ClinicaCodigo])=0 THEN 0 ELSE CONVERT( DECIMAL(28,14), [ClinicaCodigo]) END AS GXC1 FROM [Cargo] ORDER BY [ClinicaCodigo], [ConsultaId], [CargoId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmCARGOCONVE2,100,0,true,false )
             ,new CursorDef("CARGOCONVE3", "INSERT INTO [GXA0045] ([ClinicaCodigo], [ConsultaId], [CargoId], [ArticuloCodigo], [CargoPrecio], [CargoCantidad], [CargoEstado]) VALUES (@AV2ClinicaCodigo, @AV3ConsultaId, @AV4CargoId, @AV5ArticuloCodigo, @AV6CargoPrecio, @AV7CargoCantidad, @AV8CargoEstado)", GxErrorMask.GX_NOMASK,prmCARGOCONVE3)
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
                ((decimal[]) buf[1])[0] = rslt.getDecimal(2) ;
                ((decimal[]) buf[2])[0] = rslt.getDecimal(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((int[]) buf[4])[0] = rslt.getInt(5) ;
                ((int[]) buf[5])[0] = rslt.getInt(6) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(7) ;
                ((int[]) buf[7])[0] = rslt.getInt(8) ;
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
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (decimal)parms[4]);
                stmt.SetParameter(6, (decimal)parms[5]);
                stmt.SetParameter(7, (short)parms[6]);
                break;
       }
    }

 }

}
