/*
               File: oObtieneCliente
        Description: Obtiene Información de Cliente
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:3:43.1
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
   public class oobtienecliente : GXProcedure
   {
      public oobtienecliente( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public oobtienecliente( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( ref String aP0_ClinicaCodigo ,
                           ref String aP1_ClienteCodigo ,
                           ref String aP2_ClienteNombre ,
                           ref String aP3_ClienteDireccion )
      {
         this.A41ClinicaCodigo = aP0_ClinicaCodigo;
         this.A178ClienteCodigo = aP1_ClienteCodigo;
         this.AV8ClienteNombre = aP2_ClienteNombre;
         this.AV9ClienteDireccion = aP3_ClienteDireccion;
         initialize();
         executePrivate();
         aP0_ClinicaCodigo=this.A41ClinicaCodigo;
         aP1_ClienteCodigo=this.A178ClienteCodigo;
         aP2_ClienteNombre=this.AV8ClienteNombre;
         aP3_ClienteDireccion=this.AV9ClienteDireccion;
      }

      public String executeUdp( ref String aP0_ClinicaCodigo ,
                                ref String aP1_ClienteCodigo ,
                                ref String aP2_ClienteNombre )
      {
         this.A41ClinicaCodigo = aP0_ClinicaCodigo;
         this.A178ClienteCodigo = aP1_ClienteCodigo;
         this.AV8ClienteNombre = aP2_ClienteNombre;
         this.AV9ClienteDireccion = aP3_ClienteDireccion;
         initialize();
         executePrivate();
         aP0_ClinicaCodigo=this.A41ClinicaCodigo;
         aP1_ClienteCodigo=this.A178ClienteCodigo;
         aP2_ClienteNombre=this.AV8ClienteNombre;
         aP3_ClienteDireccion=this.AV9ClienteDireccion;
         return AV9ClienteDireccion ;
      }

      public void executeSubmit( ref String aP0_ClinicaCodigo ,
                                 ref String aP1_ClienteCodigo ,
                                 ref String aP2_ClienteNombre ,
                                 ref String aP3_ClienteDireccion )
      {
         oobtienecliente objoobtienecliente;
         objoobtienecliente = new oobtienecliente();
         objoobtienecliente.A41ClinicaCodigo = aP0_ClinicaCodigo;
         objoobtienecliente.A178ClienteCodigo = aP1_ClienteCodigo;
         objoobtienecliente.AV8ClienteNombre = aP2_ClienteNombre;
         objoobtienecliente.AV9ClienteDireccion = aP3_ClienteDireccion;
         objoobtienecliente.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objoobtienecliente);
         aP0_ClinicaCodigo=this.A41ClinicaCodigo;
         aP1_ClienteCodigo=this.A178ClienteCodigo;
         aP2_ClienteNombre=this.AV8ClienteNombre;
         aP3_ClienteDireccion=this.AV9ClienteDireccion;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((oobtienecliente)stateInfo).executePrivate();
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
         /* Using cursor P000N2 */
         pr_default.execute(0, new Object[] {A41ClinicaCodigo, A178ClienteCodigo});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A184ClienteEstado = P000N2_A184ClienteEstado[0] ;
            A179ClienteNombre = P000N2_A179ClienteNombre[0] ;
            A182ClienteDireccion = P000N2_A182ClienteDireccion[0] ;
            AV8ClienteNombre = A179ClienteNombre ;
            AV9ClienteDireccion = A182ClienteDireccion ;
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
         P000N2_A41ClinicaCodigo = new String[] {""} ;
         P000N2_A178ClienteCodigo = new String[] {""} ;
         P000N2_A184ClienteEstado = new short[1] ;
         P000N2_A179ClienteNombre = new String[] {""} ;
         P000N2_A182ClienteDireccion = new String[] {""} ;
         A179ClienteNombre = "" ;
         A182ClienteDireccion = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.oobtienecliente__default(),
            new Object[][] {
                new Object[] {
               P000N2_A41ClinicaCodigo, P000N2_A178ClienteCodigo, P000N2_A184ClienteEstado, P000N2_A179ClienteNombre, P000N2_A182ClienteDireccion
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short A184ClienteEstado ;
      private String scmdbuf ;
      private String A41ClinicaCodigo ;
      private String A178ClienteCodigo ;
      private String AV8ClienteNombre ;
      private String AV9ClienteDireccion ;
      private String A179ClienteNombre ;
      private String A182ClienteDireccion ;
      private IGxDataStore dsDefault ;
      private String aP0_ClinicaCodigo ;
      private String aP1_ClienteCodigo ;
      private String aP2_ClienteNombre ;
      private String aP3_ClienteDireccion ;
      private IDataStoreProvider pr_default ;
      private String[] P000N2_A41ClinicaCodigo ;
      private String[] P000N2_A178ClienteCodigo ;
      private short[] P000N2_A184ClienteEstado ;
      private String[] P000N2_A179ClienteNombre ;
      private String[] P000N2_A182ClienteDireccion ;
   }

   public class oobtienecliente__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP000N2 ;
          prmP000N2 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ClienteCodigo",SqlDbType.VarChar,10,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P000N2", "SELECT [ClinicaCodigo], [ClienteCodigo], [ClienteEstado], [ClienteNombre], [ClienteDireccion] FROM [Cliente] WITH (NOLOCK) WHERE ([ClinicaCodigo] = @ClinicaCodigo and [ClienteCodigo] = @ClienteCodigo) AND ([ClienteEstado] = 1) ORDER BY [ClinicaCodigo], [ClienteCodigo] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000N2,1,0,false,true )
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
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
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
