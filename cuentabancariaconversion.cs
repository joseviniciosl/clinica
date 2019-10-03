/*
               File: CuentaBancariaConversion
        Description: Conversion for table CuentaBancaria
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 4/1/2019 14:43:24.76
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
   public class cuentabancariaconversion : GXProcedure
   {
      public cuentabancariaconversion( )
      {
         this.DisconnectAtCleanup = true;
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public cuentabancariaconversion( IGxContext context )
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
         cuentabancariaconversion objcuentabancariaconversion;
         objcuentabancariaconversion = new cuentabancariaconversion();
         objcuentabancariaconversion.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objcuentabancariaconversion);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((cuentabancariaconversion)stateInfo).executePrivate();
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
         /* Using cursor CUENTABANC2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A137CuentaBancariaCuenta = CUENTABANC2_A137CuentaBancariaCuenta[0] ;
            A131CuentaBancariaEstado = CUENTABANC2_A131CuentaBancariaEstado[0] ;
            A126BancoCodigo = CUENTABANC2_A126BancoCodigo[0] ;
            A130CuentaBancariaTipo = CUENTABANC2_A130CuentaBancariaTipo[0] ;
            A129CuentaBancariaNombre = CUENTABANC2_A129CuentaBancariaNombre[0] ;
            A128CuentaBancariaCodigo = CUENTABANC2_A128CuentaBancariaCodigo[0] ;
            A41ClinicaCodigo = CUENTABANC2_A41ClinicaCodigo[0] ;
            A40000GXC1 = CUENTABANC2_A40000GXC1[0] ;
            /*
               INSERT RECORD ON TABLE GXA0035

            */
            AV2ClinicaCodigo = A40000GXC1 ;
            AV3CuentaBancariaCodigo = A128CuentaBancariaCodigo ;
            AV4CuentaBancariaNombre = A129CuentaBancariaNombre ;
            AV5CuentaBancariaTipo = A130CuentaBancariaTipo ;
            AV6BancoCodigo = A126BancoCodigo ;
            AV7CuentaBancariaEstado = A131CuentaBancariaEstado ;
            AV8CuentaBancariaCuenta = A137CuentaBancariaCuenta ;
            /* Using cursor CUENTABANC3 */
            pr_default.execute(1, new Object[] {AV2ClinicaCodigo, AV3CuentaBancariaCodigo, AV4CuentaBancariaNombre, AV5CuentaBancariaTipo, AV6BancoCodigo, AV7CuentaBancariaEstado, AV8CuentaBancariaCuenta});
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
         CUENTABANC2_A137CuentaBancariaCuenta = new String[] {""} ;
         CUENTABANC2_A131CuentaBancariaEstado = new short[1] ;
         CUENTABANC2_A126BancoCodigo = new String[] {""} ;
         CUENTABANC2_A130CuentaBancariaTipo = new String[] {""} ;
         CUENTABANC2_A129CuentaBancariaNombre = new String[] {""} ;
         CUENTABANC2_A128CuentaBancariaCodigo = new String[] {""} ;
         CUENTABANC2_A41ClinicaCodigo = new String[] {""} ;
         CUENTABANC2_A40000GXC1 = new int[1] ;
         A137CuentaBancariaCuenta = "" ;
         A126BancoCodigo = "" ;
         A130CuentaBancariaTipo = "" ;
         A129CuentaBancariaNombre = "" ;
         A128CuentaBancariaCodigo = "" ;
         A41ClinicaCodigo = "" ;
         AV3CuentaBancariaCodigo = "" ;
         AV4CuentaBancariaNombre = "" ;
         AV5CuentaBancariaTipo = "" ;
         AV6BancoCodigo = "" ;
         AV8CuentaBancariaCuenta = "" ;
         Gx_emsg = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.cuentabancariaconversion__default(),
            new Object[][] {
                new Object[] {
               CUENTABANC2_A137CuentaBancariaCuenta, CUENTABANC2_A131CuentaBancariaEstado, CUENTABANC2_A126BancoCodigo, CUENTABANC2_A130CuentaBancariaTipo, CUENTABANC2_A129CuentaBancariaNombre, CUENTABANC2_A128CuentaBancariaCodigo, CUENTABANC2_A41ClinicaCodigo, CUENTABANC2_A40000GXC1
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short A131CuentaBancariaEstado ;
      private short AV7CuentaBancariaEstado ;
      private int A40000GXC1 ;
      private int GIGXA0035 ;
      private int AV2ClinicaCodigo ;
      private String scmdbuf ;
      private String Gx_emsg ;
      private String A137CuentaBancariaCuenta ;
      private String A126BancoCodigo ;
      private String A130CuentaBancariaTipo ;
      private String A129CuentaBancariaNombre ;
      private String A128CuentaBancariaCodigo ;
      private String A41ClinicaCodigo ;
      private String AV3CuentaBancariaCodigo ;
      private String AV4CuentaBancariaNombre ;
      private String AV5CuentaBancariaTipo ;
      private String AV6BancoCodigo ;
      private String AV8CuentaBancariaCuenta ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] CUENTABANC2_A137CuentaBancariaCuenta ;
      private short[] CUENTABANC2_A131CuentaBancariaEstado ;
      private String[] CUENTABANC2_A126BancoCodigo ;
      private String[] CUENTABANC2_A130CuentaBancariaTipo ;
      private String[] CUENTABANC2_A129CuentaBancariaNombre ;
      private String[] CUENTABANC2_A128CuentaBancariaCodigo ;
      private String[] CUENTABANC2_A41ClinicaCodigo ;
      private int[] CUENTABANC2_A40000GXC1 ;
   }

   public class cuentabancariaconversion__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmCUENTABANC2 ;
          prmCUENTABANC2 = new Object[] {
          } ;
          Object[] prmCUENTABANC3 ;
          prmCUENTABANC3 = new Object[] {
          new Object[] {"@AV2ClinicaCodigo",SqlDbType.Int,9,0} ,
          new Object[] {"@AV3CuentaBancariaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV4CuentaBancariaNombre",SqlDbType.VarChar,30,0} ,
          new Object[] {"@AV5CuentaBancariaTipo",SqlDbType.VarChar,1,0} ,
          new Object[] {"@AV6BancoCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV7CuentaBancariaEstado",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@AV8CuentaBancariaCuenta",SqlDbType.VarChar,30,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("CUENTABANC2", "SELECT [CuentaBancariaCuenta], [CuentaBancariaEstado], [BancoCodigo], [CuentaBancariaTipo], [CuentaBancariaNombre], [CuentaBancariaCodigo], [ClinicaCodigo], CASE  WHEN ISNUMERIC([ClinicaCodigo])=0 THEN 0 ELSE CONVERT( DECIMAL(28,14), [ClinicaCodigo]) END AS GXC1 FROM [CuentaBancaria] ORDER BY [ClinicaCodigo], [CuentaBancariaCodigo] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmCUENTABANC2,100,0,true,false )
             ,new CursorDef("CUENTABANC3", "INSERT INTO [GXA0035] ([ClinicaCodigo], [CuentaBancariaCodigo], [CuentaBancariaNombre], [CuentaBancariaTipo], [BancoCodigo], [CuentaBancariaEstado], [CuentaBancariaCuenta]) VALUES (@AV2ClinicaCodigo, @AV3CuentaBancariaCodigo, @AV4CuentaBancariaNombre, @AV5CuentaBancariaTipo, @AV6BancoCodigo, @AV7CuentaBancariaEstado, @AV8CuentaBancariaCuenta)", GxErrorMask.GX_NOMASK,prmCUENTABANC3)
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
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
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
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                stmt.SetParameter(7, (String)parms[6]);
                break;
       }
    }

 }

}
