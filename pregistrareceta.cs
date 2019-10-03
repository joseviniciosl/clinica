/*
               File: pRegistraReceta
        Description: Registra Receta de Pacientes
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:3:36.58
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
   public class pregistrareceta : GXProcedure
   {
      public pregistrareceta( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public pregistrareceta( IGxContext context )
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
                           ref String aP2_RecetaObs )
      {
         this.A41ClinicaCodigo = aP0_ClinicaCodigo;
         this.A91ConsultaId = aP1_ConsultaId;
         this.AV8RecetaObs = aP2_RecetaObs;
         initialize();
         executePrivate();
         aP0_ClinicaCodigo=this.A41ClinicaCodigo;
         aP1_ConsultaId=this.A91ConsultaId;
         aP2_RecetaObs=this.AV8RecetaObs;
      }

      public String executeUdp( ref String aP0_ClinicaCodigo ,
                                ref int aP1_ConsultaId )
      {
         this.A41ClinicaCodigo = aP0_ClinicaCodigo;
         this.A91ConsultaId = aP1_ConsultaId;
         this.AV8RecetaObs = aP2_RecetaObs;
         initialize();
         executePrivate();
         aP0_ClinicaCodigo=this.A41ClinicaCodigo;
         aP1_ConsultaId=this.A91ConsultaId;
         aP2_RecetaObs=this.AV8RecetaObs;
         return AV8RecetaObs ;
      }

      public void executeSubmit( ref String aP0_ClinicaCodigo ,
                                 ref int aP1_ConsultaId ,
                                 ref String aP2_RecetaObs )
      {
         pregistrareceta objpregistrareceta;
         objpregistrareceta = new pregistrareceta();
         objpregistrareceta.A41ClinicaCodigo = aP0_ClinicaCodigo;
         objpregistrareceta.A91ConsultaId = aP1_ConsultaId;
         objpregistrareceta.AV8RecetaObs = aP2_RecetaObs;
         objpregistrareceta.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objpregistrareceta);
         aP0_ClinicaCodigo=this.A41ClinicaCodigo;
         aP1_ConsultaId=this.A91ConsultaId;
         aP2_RecetaObs=this.AV8RecetaObs;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((pregistrareceta)stateInfo).executePrivate();
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
         AV12GXLvl2 = 0 ;
         /* Using cursor P00072 */
         pr_default.execute(0, new Object[] {A41ClinicaCodigo, A91ConsultaId});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A109RecetaId = P00072_A109RecetaId[0] ;
            AV12GXLvl2 = 1 ;
            AV9RecetaId = A109RecetaId ;
            /* Exit For each command. Update data (if necessary), close cursors & exit. */
            if (true) break;
            pr_default.readNext(0);
         }
         pr_default.close(0);
         if ( AV12GXLvl2 == 0 )
         {
            AV9RecetaId = 0 ;
         }
         AV9RecetaId = (int)(AV9RecetaId+1) ;
         /*
            INSERT RECORD ON TABLE Receta

         */
         A109RecetaId = AV9RecetaId ;
         A110RecetaFecha = Gx_date ;
         A111RecetaHora = Gx_time ;
         A112RecetaObs = AV8RecetaObs ;
         /* Using cursor P00073 */
         pr_default.execute(1, new Object[] {A41ClinicaCodigo, A91ConsultaId, A109RecetaId, A110RecetaFecha, A111RecetaHora, A112RecetaObs});
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
         context.CommitDataStores("pRegistraReceta");
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
         P00072_A41ClinicaCodigo = new String[] {""} ;
         P00072_A91ConsultaId = new int[1] ;
         P00072_A109RecetaId = new int[1] ;
         A110RecetaFecha = DateTime.MinValue ;
         Gx_date = DateTime.MinValue ;
         A111RecetaHora = "" ;
         Gx_time = "" ;
         A112RecetaObs = "" ;
         Gx_emsg = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.pregistrareceta__default(),
            new Object[][] {
                new Object[] {
               P00072_A41ClinicaCodigo, P00072_A91ConsultaId, P00072_A109RecetaId
               }
               , new Object[] {
               }
            }
         );
         Gx_time = context.localUtil.Time( ) ;
         Gx_date = DateTimeUtil.Today( ) ;
         /* GeneXus formulas. */
         Gx_time = context.localUtil.Time( ) ;
         Gx_date = DateTimeUtil.Today( ) ;
         context.Gx_err = 0 ;
      }

      private short AV12GXLvl2 ;
      private int A91ConsultaId ;
      private int A109RecetaId ;
      private int AV9RecetaId ;
      private int GX_INS27 ;
      private String scmdbuf ;
      private String A111RecetaHora ;
      private String Gx_time ;
      private String Gx_emsg ;
      private DateTime A110RecetaFecha ;
      private DateTime Gx_date ;
      private String A41ClinicaCodigo ;
      private String AV8RecetaObs ;
      private String A112RecetaObs ;
      private IGxDataStore dsDefault ;
      private String aP0_ClinicaCodigo ;
      private int aP1_ConsultaId ;
      private String aP2_RecetaObs ;
      private IDataStoreProvider pr_default ;
      private String[] P00072_A41ClinicaCodigo ;
      private int[] P00072_A91ConsultaId ;
      private int[] P00072_A109RecetaId ;
   }

   public class pregistrareceta__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP00072 ;
          prmP00072 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ConsultaId",SqlDbType.Int,9,0}
          } ;
          Object[] prmP00073 ;
          prmP00073 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ConsultaId",SqlDbType.Int,9,0} ,
          new Object[] {"@RecetaId",SqlDbType.Int,9,0} ,
          new Object[] {"@RecetaFecha",SqlDbType.DateTime,8,0} ,
          new Object[] {"@RecetaHora",SqlDbType.Char,8,0} ,
          new Object[] {"@RecetaObs",SqlDbType.VarChar,600,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00072", "SELECT TOP 1 [ClinicaCodigo], [ConsultaId], [RecetaId] FROM [Receta] WITH (NOLOCK) WHERE ([ClinicaCodigo] = @ClinicaCodigo) AND ([ConsultaId] = @ConsultaId) ORDER BY [RecetaId] DESC ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00072,1,0,false,true )
             ,new CursorDef("P00073", "INSERT INTO [Receta] ([ClinicaCodigo], [ConsultaId], [RecetaId], [RecetaFecha], [RecetaHora], [RecetaObs]) VALUES (@ClinicaCodigo, @ConsultaId, @RecetaId, @RecetaFecha, @RecetaHora, @RecetaObs)", GxErrorMask.GX_NOMASK,prmP00073)
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
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
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
                break;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                stmt.SetParameter(4, (DateTime)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                break;
       }
    }

 }

}
