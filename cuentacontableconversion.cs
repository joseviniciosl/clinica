/*
               File: CuentaContableConversion
        Description: Conversion for table CuentaContable
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 4/1/2019 14:43:24.85
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
   public class cuentacontableconversion : GXProcedure
   {
      public cuentacontableconversion( )
      {
         this.DisconnectAtCleanup = true;
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public cuentacontableconversion( IGxContext context )
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
         cuentacontableconversion objcuentacontableconversion;
         objcuentacontableconversion = new cuentacontableconversion();
         objcuentacontableconversion.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objcuentacontableconversion);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((cuentacontableconversion)stateInfo).executePrivate();
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
         /* Using cursor CUENTACONT2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A198CtaContableEstado = CUENTACONT2_A198CtaContableEstado[0] ;
            A197CtaContableManual = CUENTACONT2_A197CtaContableManual[0] ;
            A196CtaContableGrupo = CUENTACONT2_A196CtaContableGrupo[0] ;
            A195CtaContableNivel = CUENTACONT2_A195CtaContableNivel[0] ;
            A194CtaContableNombre = CUENTACONT2_A194CtaContableNombre[0] ;
            A193CtaContableCodigo = CUENTACONT2_A193CtaContableCodigo[0] ;
            A41ClinicaCodigo = CUENTACONT2_A41ClinicaCodigo[0] ;
            A40000GXC1 = CUENTACONT2_A40000GXC1[0] ;
            /*
               INSERT RECORD ON TABLE GXA0050

            */
            AV2ClinicaCodigo = A40000GXC1 ;
            AV3CtaContableCodigo = A193CtaContableCodigo ;
            AV4CtaContableNombre = A194CtaContableNombre ;
            AV5CtaContableNivel = A195CtaContableNivel ;
            AV6CtaContableGrupo = A196CtaContableGrupo ;
            AV7CtaContableManual = A197CtaContableManual ;
            AV8CtaContableEstado = A198CtaContableEstado ;
            /* Using cursor CUENTACONT3 */
            pr_default.execute(1, new Object[] {AV2ClinicaCodigo, AV3CtaContableCodigo, AV4CtaContableNombre, AV5CtaContableNivel, AV6CtaContableGrupo, AV7CtaContableManual, AV8CtaContableEstado});
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
         CUENTACONT2_A198CtaContableEstado = new short[1] ;
         CUENTACONT2_A197CtaContableManual = new short[1] ;
         CUENTACONT2_A196CtaContableGrupo = new String[] {""} ;
         CUENTACONT2_A195CtaContableNivel = new short[1] ;
         CUENTACONT2_A194CtaContableNombre = new String[] {""} ;
         CUENTACONT2_A193CtaContableCodigo = new String[] {""} ;
         CUENTACONT2_A41ClinicaCodigo = new String[] {""} ;
         CUENTACONT2_A40000GXC1 = new int[1] ;
         A196CtaContableGrupo = "" ;
         A194CtaContableNombre = "" ;
         A193CtaContableCodigo = "" ;
         A41ClinicaCodigo = "" ;
         AV3CtaContableCodigo = "" ;
         AV4CtaContableNombre = "" ;
         AV6CtaContableGrupo = "" ;
         Gx_emsg = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.cuentacontableconversion__default(),
            new Object[][] {
                new Object[] {
               CUENTACONT2_A198CtaContableEstado, CUENTACONT2_A197CtaContableManual, CUENTACONT2_A196CtaContableGrupo, CUENTACONT2_A195CtaContableNivel, CUENTACONT2_A194CtaContableNombre, CUENTACONT2_A193CtaContableCodigo, CUENTACONT2_A41ClinicaCodigo, CUENTACONT2_A40000GXC1
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short A198CtaContableEstado ;
      private short A197CtaContableManual ;
      private short A195CtaContableNivel ;
      private short AV5CtaContableNivel ;
      private short AV7CtaContableManual ;
      private short AV8CtaContableEstado ;
      private int A40000GXC1 ;
      private int GIGXA0050 ;
      private int AV2ClinicaCodigo ;
      private String scmdbuf ;
      private String Gx_emsg ;
      private String A196CtaContableGrupo ;
      private String A194CtaContableNombre ;
      private String A193CtaContableCodigo ;
      private String A41ClinicaCodigo ;
      private String AV3CtaContableCodigo ;
      private String AV4CtaContableNombre ;
      private String AV6CtaContableGrupo ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] CUENTACONT2_A198CtaContableEstado ;
      private short[] CUENTACONT2_A197CtaContableManual ;
      private String[] CUENTACONT2_A196CtaContableGrupo ;
      private short[] CUENTACONT2_A195CtaContableNivel ;
      private String[] CUENTACONT2_A194CtaContableNombre ;
      private String[] CUENTACONT2_A193CtaContableCodigo ;
      private String[] CUENTACONT2_A41ClinicaCodigo ;
      private int[] CUENTACONT2_A40000GXC1 ;
   }

   public class cuentacontableconversion__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmCUENTACONT2 ;
          prmCUENTACONT2 = new Object[] {
          } ;
          Object[] prmCUENTACONT3 ;
          prmCUENTACONT3 = new Object[] {
          new Object[] {"@AV2ClinicaCodigo",SqlDbType.Int,9,0} ,
          new Object[] {"@AV3CtaContableCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV4CtaContableNombre",SqlDbType.VarChar,80,0} ,
          new Object[] {"@AV5CtaContableNivel",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@AV6CtaContableGrupo",SqlDbType.VarChar,15,0} ,
          new Object[] {"@AV7CtaContableManual",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@AV8CtaContableEstado",SqlDbType.SmallInt,1,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("CUENTACONT2", "SELECT [CtaContableEstado], [CtaContableManual], [CtaContableGrupo], [CtaContableNivel], [CtaContableNombre], [CtaContableCodigo], [ClinicaCodigo], CASE  WHEN ISNUMERIC([ClinicaCodigo])=0 THEN 0 ELSE CONVERT( DECIMAL(28,14), [ClinicaCodigo]) END AS GXC1 FROM [CuentaContable] ORDER BY [ClinicaCodigo], [CtaContableCodigo] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmCUENTACONT2,100,0,true,false )
             ,new CursorDef("CUENTACONT3", "INSERT INTO [GXA0050] ([ClinicaCodigo], [CtaContableCodigo], [CtaContableNombre], [CtaContableNivel], [CtaContableGrupo], [CtaContableManual], [CtaContableEstado]) VALUES (@AV2ClinicaCodigo, @AV3CtaContableCodigo, @AV4CtaContableNombre, @AV5CtaContableNivel, @AV6CtaContableGrupo, @AV7CtaContableManual, @AV8CtaContableEstado)", GxErrorMask.GX_NOMASK,prmCUENTACONT3)
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
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
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
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                stmt.SetParameter(7, (short)parms[6]);
                break;
       }
    }

 }

}
