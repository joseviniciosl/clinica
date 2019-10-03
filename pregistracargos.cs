/*
               File: pRegistraCargos
        Description: Registra Cargos de Consulta de Pacientes
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:3:37.28
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
   public class pregistracargos : GXProcedure
   {
      public pregistracargos( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public pregistracargos( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( ref String aP0_ClinicaCodigo ,
                           ref int aP1_ConsultaId ,
                           ref String aP2_ArticuloCodigo ,
                           ref decimal aP3_CargoPrecio ,
                           ref decimal aP4_CargoCantidad ,
                           ref short aP5_CargoEstado )
      {
         this.A41ClinicaCodigo = aP0_ClinicaCodigo;
         this.A91ConsultaId = aP1_ConsultaId;
         this.A30ArticuloCodigo = aP2_ArticuloCodigo;
         this.A163CargoPrecio = aP3_CargoPrecio;
         this.A164CargoCantidad = aP4_CargoCantidad;
         this.AV9CargoEstado = aP5_CargoEstado;
         initialize();
         executePrivate();
         aP0_ClinicaCodigo=this.A41ClinicaCodigo;
         aP1_ConsultaId=this.A91ConsultaId;
         aP2_ArticuloCodigo=this.A30ArticuloCodigo;
         aP3_CargoPrecio=this.A163CargoPrecio;
         aP4_CargoCantidad=this.A164CargoCantidad;
         aP5_CargoEstado=this.AV9CargoEstado;
      }

      public short executeUdp( ref String aP0_ClinicaCodigo ,
                               ref int aP1_ConsultaId ,
                               ref String aP2_ArticuloCodigo ,
                               ref decimal aP3_CargoPrecio ,
                               ref decimal aP4_CargoCantidad )
      {
         this.A41ClinicaCodigo = aP0_ClinicaCodigo;
         this.A91ConsultaId = aP1_ConsultaId;
         this.A30ArticuloCodigo = aP2_ArticuloCodigo;
         this.A163CargoPrecio = aP3_CargoPrecio;
         this.A164CargoCantidad = aP4_CargoCantidad;
         this.AV9CargoEstado = aP5_CargoEstado;
         initialize();
         executePrivate();
         aP0_ClinicaCodigo=this.A41ClinicaCodigo;
         aP1_ConsultaId=this.A91ConsultaId;
         aP2_ArticuloCodigo=this.A30ArticuloCodigo;
         aP3_CargoPrecio=this.A163CargoPrecio;
         aP4_CargoCantidad=this.A164CargoCantidad;
         aP5_CargoEstado=this.AV9CargoEstado;
         return AV9CargoEstado ;
      }

      public void executeSubmit( ref String aP0_ClinicaCodigo ,
                                 ref int aP1_ConsultaId ,
                                 ref String aP2_ArticuloCodigo ,
                                 ref decimal aP3_CargoPrecio ,
                                 ref decimal aP4_CargoCantidad ,
                                 ref short aP5_CargoEstado )
      {
         pregistracargos objpregistracargos;
         objpregistracargos = new pregistracargos();
         objpregistracargos.A41ClinicaCodigo = aP0_ClinicaCodigo;
         objpregistracargos.A91ConsultaId = aP1_ConsultaId;
         objpregistracargos.A30ArticuloCodigo = aP2_ArticuloCodigo;
         objpregistracargos.A163CargoPrecio = aP3_CargoPrecio;
         objpregistracargos.A164CargoCantidad = aP4_CargoCantidad;
         objpregistracargos.AV9CargoEstado = aP5_CargoEstado;
         objpregistracargos.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objpregistracargos);
         aP0_ClinicaCodigo=this.A41ClinicaCodigo;
         aP1_ConsultaId=this.A91ConsultaId;
         aP2_ArticuloCodigo=this.A30ArticuloCodigo;
         aP3_CargoPrecio=this.A163CargoPrecio;
         aP4_CargoCantidad=this.A164CargoCantidad;
         aP5_CargoEstado=this.AV9CargoEstado;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((pregistracargos)stateInfo).executePrivate();
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
         AV12GXLvl3 = 0 ;
         /* Using cursor P00092 */
         pr_default.execute(0, new Object[] {A41ClinicaCodigo, A91ConsultaId, A30ArticuloCodigo, A163CargoPrecio, A164CargoCantidad});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A162CargoId = P00092_A162CargoId[0] ;
            AV12GXLvl3 = 1 ;
            AV8CargoId = A162CargoId ;
            /* Exit For each command. Update data (if necessary), close cursors & exit. */
            if (true) break;
            pr_default.readNext(0);
         }
         pr_default.close(0);
         if ( AV12GXLvl3 == 0 )
         {
            AV8CargoId = 0 ;
         }
         AV8CargoId = (int)(AV8CargoId+1) ;
         /*
            INSERT RECORD ON TABLE Cargo

         */
         A162CargoId = AV8CargoId ;
         A166CargoEstado = AV9CargoEstado ;
         /* Using cursor P00093 */
         pr_default.execute(1, new Object[] {A41ClinicaCodigo, A91ConsultaId, A162CargoId, A30ArticuloCodigo, A163CargoPrecio, A164CargoCantidad, A166CargoEstado});
         pr_default.close(1);
         if ( (pr_default.getStatus(1) == 1) )
         {
            context.Gx_err = 1 ;
            Gx_emsg = (String)(context.GetMessage( "GXM_noupdate", "")) ;
         }
         else
         {
            context.Gx_err = 0 ;
            Gx_emsg = "" ;
         }
         /* End Insert */
         this.cleanup();
      }

      protected void cleanup( )
      {
         context.CommitDataStores("pRegistraCargos");
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
         P00092_A41ClinicaCodigo = new String[] {""} ;
         P00092_A91ConsultaId = new int[1] ;
         P00092_A30ArticuloCodigo = new String[] {""} ;
         P00092_A163CargoPrecio = new decimal[1] ;
         P00092_A164CargoCantidad = new decimal[1] ;
         P00092_A162CargoId = new int[1] ;
         Gx_emsg = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.pregistracargos__default(),
            new Object[][] {
                new Object[] {
               P00092_A41ClinicaCodigo, P00092_A91ConsultaId, P00092_A30ArticuloCodigo, P00092_A163CargoPrecio, P00092_A164CargoCantidad, P00092_A162CargoId
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short AV9CargoEstado ;
      private short AV12GXLvl3 ;
      private short A166CargoEstado ;
      private int A91ConsultaId ;
      private int A162CargoId ;
      private int AV8CargoId ;
      private int GX_INS45 ;
      private decimal A163CargoPrecio ;
      private decimal A164CargoCantidad ;
      private String scmdbuf ;
      private String Gx_emsg ;
      private String A41ClinicaCodigo ;
      private String A30ArticuloCodigo ;
      private IGxDataStore dsDefault ;
      private String aP0_ClinicaCodigo ;
      private int aP1_ConsultaId ;
      private String aP2_ArticuloCodigo ;
      private decimal aP3_CargoPrecio ;
      private decimal aP4_CargoCantidad ;
      private short aP5_CargoEstado ;
      private IDataStoreProvider pr_default ;
      private String[] P00092_A41ClinicaCodigo ;
      private int[] P00092_A91ConsultaId ;
      private String[] P00092_A30ArticuloCodigo ;
      private decimal[] P00092_A163CargoPrecio ;
      private decimal[] P00092_A164CargoCantidad ;
      private int[] P00092_A162CargoId ;
   }

   public class pregistracargos__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP00092 ;
          prmP00092 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ConsultaId",SqlDbType.Int,9,0} ,
          new Object[] {"@ArticuloCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CargoPrecio",SqlDbType.Decimal,17,2} ,
          new Object[] {"@CargoCantidad",SqlDbType.Decimal,17,2}
          } ;
          Object[] prmP00093 ;
          prmP00093 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ConsultaId",SqlDbType.Int,9,0} ,
          new Object[] {"@CargoId",SqlDbType.Int,9,0} ,
          new Object[] {"@ArticuloCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CargoPrecio",SqlDbType.Decimal,17,2} ,
          new Object[] {"@CargoCantidad",SqlDbType.Decimal,17,2} ,
          new Object[] {"@CargoEstado",SqlDbType.SmallInt,1,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00092", "SELECT TOP 1 [ClinicaCodigo], [ConsultaId], [ArticuloCodigo], [CargoPrecio], [CargoCantidad], [CargoId] FROM [Cargo] WITH (NOLOCK) WHERE ([ClinicaCodigo] = @ClinicaCodigo) AND ([ConsultaId] = @ConsultaId) AND ([ArticuloCodigo] = @ArticuloCodigo) AND ([CargoPrecio] = @CargoPrecio) AND ([CargoCantidad] = @CargoCantidad) ORDER BY [CargoId] DESC ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00092,1,0,false,true )
             ,new CursorDef("P00093", "INSERT INTO [Cargo] ([ClinicaCodigo], [ConsultaId], [CargoId], [ArticuloCodigo], [CargoPrecio], [CargoCantidad], [CargoEstado]) VALUES (@ClinicaCodigo, @ConsultaId, @CargoId, @ArticuloCodigo, @CargoPrecio, @CargoCantidad, @CargoEstado)", GxErrorMask.GX_NOMASK,prmP00093)
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
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((decimal[]) buf[3])[0] = rslt.getDecimal(4) ;
                ((decimal[]) buf[4])[0] = rslt.getDecimal(5) ;
                ((int[]) buf[5])[0] = rslt.getInt(6) ;
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
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (decimal)parms[3]);
                stmt.SetParameter(5, (decimal)parms[4]);
                break;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
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
