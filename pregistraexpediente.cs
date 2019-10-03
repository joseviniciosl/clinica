/*
               File: pRegistraExpediente
        Description: Registra Expediente Médico Físico de Paciente
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:3:38.55
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
   public class pregistraexpediente : GXProcedure
   {
      public pregistraexpediente( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public pregistraexpediente( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( ref String aP0_ClinicaCodigo ,
                           ref int aP1_PacienteId ,
                           ref int aP2_ExpedienteId ,
                           ref DateTime aP3_ExpedienteFecha ,
                           ref String aP4_ExpedienteHora ,
                           ref String aP5_ExpedienteObs ,
                           ref String aP6_UsuarioCodigo )
      {
         this.A41ClinicaCodigo = aP0_ClinicaCodigo;
         this.AV10PacienteId = aP1_PacienteId;
         this.A167ExpedienteId = aP2_ExpedienteId;
         this.AV12ExpedienteFecha = aP3_ExpedienteFecha;
         this.AV13ExpedienteHora = aP4_ExpedienteHora;
         this.AV14ExpedienteObs = aP5_ExpedienteObs;
         this.AV15UsuarioCodigo = aP6_UsuarioCodigo;
         initialize();
         executePrivate();
         aP0_ClinicaCodigo=this.A41ClinicaCodigo;
         aP1_PacienteId=this.AV10PacienteId;
         aP2_ExpedienteId=this.A167ExpedienteId;
         aP3_ExpedienteFecha=this.AV12ExpedienteFecha;
         aP4_ExpedienteHora=this.AV13ExpedienteHora;
         aP5_ExpedienteObs=this.AV14ExpedienteObs;
         aP6_UsuarioCodigo=this.AV15UsuarioCodigo;
      }

      public String executeUdp( ref String aP0_ClinicaCodigo ,
                                ref int aP1_PacienteId ,
                                ref int aP2_ExpedienteId ,
                                ref DateTime aP3_ExpedienteFecha ,
                                ref String aP4_ExpedienteHora ,
                                ref String aP5_ExpedienteObs )
      {
         this.A41ClinicaCodigo = aP0_ClinicaCodigo;
         this.AV10PacienteId = aP1_PacienteId;
         this.A167ExpedienteId = aP2_ExpedienteId;
         this.AV12ExpedienteFecha = aP3_ExpedienteFecha;
         this.AV13ExpedienteHora = aP4_ExpedienteHora;
         this.AV14ExpedienteObs = aP5_ExpedienteObs;
         this.AV15UsuarioCodigo = aP6_UsuarioCodigo;
         initialize();
         executePrivate();
         aP0_ClinicaCodigo=this.A41ClinicaCodigo;
         aP1_PacienteId=this.AV10PacienteId;
         aP2_ExpedienteId=this.A167ExpedienteId;
         aP3_ExpedienteFecha=this.AV12ExpedienteFecha;
         aP4_ExpedienteHora=this.AV13ExpedienteHora;
         aP5_ExpedienteObs=this.AV14ExpedienteObs;
         aP6_UsuarioCodigo=this.AV15UsuarioCodigo;
         return AV15UsuarioCodigo ;
      }

      public void executeSubmit( ref String aP0_ClinicaCodigo ,
                                 ref int aP1_PacienteId ,
                                 ref int aP2_ExpedienteId ,
                                 ref DateTime aP3_ExpedienteFecha ,
                                 ref String aP4_ExpedienteHora ,
                                 ref String aP5_ExpedienteObs ,
                                 ref String aP6_UsuarioCodigo )
      {
         pregistraexpediente objpregistraexpediente;
         objpregistraexpediente = new pregistraexpediente();
         objpregistraexpediente.A41ClinicaCodigo = aP0_ClinicaCodigo;
         objpregistraexpediente.AV10PacienteId = aP1_PacienteId;
         objpregistraexpediente.A167ExpedienteId = aP2_ExpedienteId;
         objpregistraexpediente.AV12ExpedienteFecha = aP3_ExpedienteFecha;
         objpregistraexpediente.AV13ExpedienteHora = aP4_ExpedienteHora;
         objpregistraexpediente.AV14ExpedienteObs = aP5_ExpedienteObs;
         objpregistraexpediente.AV15UsuarioCodigo = aP6_UsuarioCodigo;
         objpregistraexpediente.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objpregistraexpediente);
         aP0_ClinicaCodigo=this.A41ClinicaCodigo;
         aP1_PacienteId=this.AV10PacienteId;
         aP2_ExpedienteId=this.A167ExpedienteId;
         aP3_ExpedienteFecha=this.AV12ExpedienteFecha;
         aP4_ExpedienteHora=this.AV13ExpedienteHora;
         aP5_ExpedienteObs=this.AV14ExpedienteObs;
         aP6_UsuarioCodigo=this.AV15UsuarioCodigo;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((pregistraexpediente)stateInfo).executePrivate();
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
         /*
            INSERT RECORD ON TABLE Expediente

         */
         A168ExpedienteFecha = AV12ExpedienteFecha ;
         A169ExpedienteHora = AV13ExpedienteHora ;
         A67PacienteId = AV10PacienteId ;
         A4UsuarioCodigo = AV15UsuarioCodigo ;
         A176ExpedienteObs = AV14ExpedienteObs ;
         /* Using cursor P000C2 */
         pr_default.execute(0, new Object[] {A41ClinicaCodigo, A167ExpedienteId, A168ExpedienteFecha, A169ExpedienteHora, A67PacienteId, A4UsuarioCodigo, A176ExpedienteObs});
         pr_default.close(0);
         if ( (pr_default.getStatus(0) == 1) )
         {
            context.Gx_err = 1 ;
            Gx_emsg = (String)(context.GetMessage( "GXM_noupdate", "")) ;
            /* Optimized UPDATE. */
            /* Using cursor P000C3 */
            pr_default.execute(1, new Object[] {AV14ExpedienteObs, AV15UsuarioCodigo, A41ClinicaCodigo, A167ExpedienteId});
            pr_default.close(1);
            /* End optimized UPDATE. */
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
         context.CommitDataStores("pRegistraExpediente");
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
         A168ExpedienteFecha = DateTime.MinValue ;
         A169ExpedienteHora = "" ;
         A4UsuarioCodigo = "" ;
         A176ExpedienteObs = "" ;
         Gx_emsg = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.pregistraexpediente__default(),
            new Object[][] {
                new Object[] {
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private int AV10PacienteId ;
      private int A167ExpedienteId ;
      private int GX_INS46 ;
      private int A67PacienteId ;
      private String AV13ExpedienteHora ;
      private String A169ExpedienteHora ;
      private String Gx_emsg ;
      private DateTime AV12ExpedienteFecha ;
      private DateTime A168ExpedienteFecha ;
      private String A41ClinicaCodigo ;
      private String AV14ExpedienteObs ;
      private String AV15UsuarioCodigo ;
      private String A4UsuarioCodigo ;
      private String A176ExpedienteObs ;
      private IGxDataStore dsDefault ;
      private String aP0_ClinicaCodigo ;
      private int aP1_PacienteId ;
      private int aP2_ExpedienteId ;
      private DateTime aP3_ExpedienteFecha ;
      private String aP4_ExpedienteHora ;
      private String aP5_ExpedienteObs ;
      private String aP6_UsuarioCodigo ;
      private IDataStoreProvider pr_default ;
   }

   public class pregistraexpediente__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new UpdateCursor(def[0])
         ,new UpdateCursor(def[1])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP000C2 ;
          prmP000C2 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ExpedienteId",SqlDbType.Int,9,0} ,
          new Object[] {"@ExpedienteFecha",SqlDbType.DateTime,8,0} ,
          new Object[] {"@ExpedienteHora",SqlDbType.Char,8,0} ,
          new Object[] {"@PacienteId",SqlDbType.Int,9,0} ,
          new Object[] {"@UsuarioCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ExpedienteObs",SqlDbType.VarChar,600,0}
          } ;
          Object[] prmP000C3 ;
          prmP000C3 = new Object[] {
          new Object[] {"@ExpedienteObs",SqlDbType.VarChar,600,0} ,
          new Object[] {"@UsuarioCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ExpedienteId",SqlDbType.Int,9,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P000C2", "INSERT INTO [Expediente] ([ClinicaCodigo], [ExpedienteId], [ExpedienteFecha], [ExpedienteHora], [PacienteId], [UsuarioCodigo], [ExpedienteObs]) VALUES (@ClinicaCodigo, @ExpedienteId, @ExpedienteFecha, @ExpedienteHora, @PacienteId, @UsuarioCodigo, @ExpedienteObs)", GxErrorMask.GX_NOMASK,prmP000C2)
             ,new CursorDef("P000C3", "UPDATE [Expediente] SET [ExpedienteObs]=@ExpedienteObs, [UsuarioCodigo]=@UsuarioCodigo  WHERE [ClinicaCodigo] = @ClinicaCodigo and [ExpedienteId] = @ExpedienteId", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP000C3)
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
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
                stmt.SetParameter(3, (DateTime)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (int)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                stmt.SetParameter(7, (String)parms[6]);
                break;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (int)parms[3]);
                break;
       }
    }

 }

}
