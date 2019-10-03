/*
               File: oObtieneCuentaContable
        Description: Obtiene Cuenta Contable
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:3:54.43
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
   public class oobtienecuentacontable : GXProcedure
   {
      public oobtienecuentacontable( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public oobtienecuentacontable( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( ref String aP0_ClinicaCodigo ,
                           ref String aP1_CtaContableCodigo ,
                           ref String aP2_CtaContableNombre ,
                           ref short aP3_CtaContableNivel ,
                           ref short aP4_CtaContableManual )
      {
         this.A41ClinicaCodigo = aP0_ClinicaCodigo;
         this.A193CtaContableCodigo = aP1_CtaContableCodigo;
         this.AV8CtaContableNombre = aP2_CtaContableNombre;
         this.AV9CtaContableNivel = aP3_CtaContableNivel;
         this.AV12CtaContableManual = aP4_CtaContableManual;
         initialize();
         executePrivate();
         aP0_ClinicaCodigo=this.A41ClinicaCodigo;
         aP1_CtaContableCodigo=this.A193CtaContableCodigo;
         aP2_CtaContableNombre=this.AV8CtaContableNombre;
         aP3_CtaContableNivel=this.AV9CtaContableNivel;
         aP4_CtaContableManual=this.AV12CtaContableManual;
      }

      public short executeUdp( ref String aP0_ClinicaCodigo ,
                               ref String aP1_CtaContableCodigo ,
                               ref String aP2_CtaContableNombre ,
                               ref short aP3_CtaContableNivel )
      {
         this.A41ClinicaCodigo = aP0_ClinicaCodigo;
         this.A193CtaContableCodigo = aP1_CtaContableCodigo;
         this.AV8CtaContableNombre = aP2_CtaContableNombre;
         this.AV9CtaContableNivel = aP3_CtaContableNivel;
         this.AV12CtaContableManual = aP4_CtaContableManual;
         initialize();
         executePrivate();
         aP0_ClinicaCodigo=this.A41ClinicaCodigo;
         aP1_CtaContableCodigo=this.A193CtaContableCodigo;
         aP2_CtaContableNombre=this.AV8CtaContableNombre;
         aP3_CtaContableNivel=this.AV9CtaContableNivel;
         aP4_CtaContableManual=this.AV12CtaContableManual;
         return AV12CtaContableManual ;
      }

      public void executeSubmit( ref String aP0_ClinicaCodigo ,
                                 ref String aP1_CtaContableCodigo ,
                                 ref String aP2_CtaContableNombre ,
                                 ref short aP3_CtaContableNivel ,
                                 ref short aP4_CtaContableManual )
      {
         oobtienecuentacontable objoobtienecuentacontable;
         objoobtienecuentacontable = new oobtienecuentacontable();
         objoobtienecuentacontable.A41ClinicaCodigo = aP0_ClinicaCodigo;
         objoobtienecuentacontable.A193CtaContableCodigo = aP1_CtaContableCodigo;
         objoobtienecuentacontable.AV8CtaContableNombre = aP2_CtaContableNombre;
         objoobtienecuentacontable.AV9CtaContableNivel = aP3_CtaContableNivel;
         objoobtienecuentacontable.AV12CtaContableManual = aP4_CtaContableManual;
         objoobtienecuentacontable.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objoobtienecuentacontable);
         aP0_ClinicaCodigo=this.A41ClinicaCodigo;
         aP1_CtaContableCodigo=this.A193CtaContableCodigo;
         aP2_CtaContableNombre=this.AV8CtaContableNombre;
         aP3_CtaContableNivel=this.AV9CtaContableNivel;
         aP4_CtaContableManual=this.AV12CtaContableManual;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((oobtienecuentacontable)stateInfo).executePrivate();
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
         /* Using cursor P00132 */
         pr_default.execute(0, new Object[] {A41ClinicaCodigo, A193CtaContableCodigo});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A198CtaContableEstado = P00132_A198CtaContableEstado[0] ;
            A194CtaContableNombre = P00132_A194CtaContableNombre[0] ;
            A195CtaContableNivel = P00132_A195CtaContableNivel[0] ;
            A197CtaContableManual = P00132_A197CtaContableManual[0] ;
            if ( A198CtaContableEstado == 0 )
            {
               AV9CtaContableNivel = 0 ;
               AV8CtaContableNombre = "" ;
               GX_msglist.addItem("Cuenta contable está de baja.");
            }
            else
            {
               AV8CtaContableNombre = A194CtaContableNombre ;
               AV9CtaContableNivel = A195CtaContableNivel ;
               AV12CtaContableManual = A197CtaContableManual ;
            }
            /* Exiting from a For First loop. */
            if (true) break;
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
         P00132_A41ClinicaCodigo = new String[] {""} ;
         P00132_A193CtaContableCodigo = new String[] {""} ;
         P00132_A198CtaContableEstado = new short[1] ;
         P00132_A194CtaContableNombre = new String[] {""} ;
         P00132_A195CtaContableNivel = new short[1] ;
         P00132_A197CtaContableManual = new short[1] ;
         A194CtaContableNombre = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.oobtienecuentacontable__default(),
            new Object[][] {
                new Object[] {
               P00132_A41ClinicaCodigo, P00132_A193CtaContableCodigo, P00132_A198CtaContableEstado, P00132_A194CtaContableNombre, P00132_A195CtaContableNivel, P00132_A197CtaContableManual
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short AV9CtaContableNivel ;
      private short AV12CtaContableManual ;
      private short A198CtaContableEstado ;
      private short A195CtaContableNivel ;
      private short A197CtaContableManual ;
      private String scmdbuf ;
      private String A41ClinicaCodigo ;
      private String A193CtaContableCodigo ;
      private String AV8CtaContableNombre ;
      private String A194CtaContableNombre ;
      private IGxDataStore dsDefault ;
      private String aP0_ClinicaCodigo ;
      private String aP1_CtaContableCodigo ;
      private String aP2_CtaContableNombre ;
      private short aP3_CtaContableNivel ;
      private short aP4_CtaContableManual ;
      private IDataStoreProvider pr_default ;
      private String[] P00132_A41ClinicaCodigo ;
      private String[] P00132_A193CtaContableCodigo ;
      private short[] P00132_A198CtaContableEstado ;
      private String[] P00132_A194CtaContableNombre ;
      private short[] P00132_A195CtaContableNivel ;
      private short[] P00132_A197CtaContableManual ;
   }

   public class oobtienecuentacontable__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP00132 ;
          prmP00132 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CtaContableCodigo",SqlDbType.VarChar,10,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00132", "SELECT [ClinicaCodigo], [CtaContableCodigo], [CtaContableEstado], [CtaContableNombre], [CtaContableNivel], [CtaContableManual] FROM [CuentaContable] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo and [CtaContableCodigo] = @CtaContableCodigo ORDER BY [ClinicaCodigo], [CtaContableCodigo] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00132,1,0,false,true )
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
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
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
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
       }
    }

 }

}
