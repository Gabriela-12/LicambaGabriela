/*
 * Creado por SharpDevelop.
 * Usuario: GABRIELA LOZANO 
 * Fecha: 04/06/2019
 * Hora: 11:01 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LicambaGabrielaLozano
{System.ComponentModel privado . Componentes de IContainer  = nulo ;  
		System.Windows.Forms privados . Botón  btnLogin ;
		System.Windows.Forms privados . TextBox  txtPassword ;
		System.Windows.Forms privados . TextBox  txtUser ;
		System.Windows.Forms privados . Etiqueta  label1 ;
		System.Windows.Forms privados . Etiqueta  label2 ;
		System.Windows.Forms privados . Label  lblRecovery ;
		System.Windows.Forms privados . PictureBox  pictureBox1 
	/// <summary>
	/// Description of menu_principal.
	/// </summary>
	public partial class menu_principal : Form
	{
		public menu_principal()
		/// < param  name = " disposing " > true si se deben eliminar los recursos administrados; de lo contrario, falso. </ param >
		 anulación  protegida void  Eliminar ( eliminación de bool  )
		{
			si ( disposición ) {
				if ( componentes  ! =  nulo ) {
					componentes . Eliminar ();
				}
			}
			de base . Disponer ( disponer );
		}Sistema . ComponentModel . Recursos de ComponentResourceManager  = nuevo sistema . ComponentModel . ComponentResourceManager ( typeof ( FormLogin ));   
            esta . btnLogin  =  nuevo  sistema . Ventanas . Formas . Botón ();
            esta . txtPassword  =  nuevo  sistema . Ventanas . Formas . TextBox ();
            esta . txtUser  =  nuevo  sistema . Ventanas . Formas . TextBox ();
            esta . label1  =  nuevo  sistema . Ventanas . Formas . Etiqueta ();
            esta . label2  =  nuevo  sistema . Ventanas . Formas . Etiqueta ();
            esta . lblRecovery  =  nuevo  sistema . Ventanas . Formas . Etiqueta ();
            esta . pictureBox1  =  nuevo  sistema . Ventanas . Formas . PictureBox ();
            (( System . ComponentModel . ISupportInitialize ) ( this . PictureBox1 )). BeginInit ();
            esta . SuspendLayout ();
            // 
            // btnLogin
            // 
            esta . btnlogin . Ubicación  =  nuevo  sistema . Dibujo . Punto ( 98 , 316 );
            esta . btnlogin . Nombre  =  " btnLogin " ;
            esta . btnlogin . Tamaño  =  nuevo  sistema . Dibujo . Tamaño ( 99 , 34 );
            esta . btnlogin . TabIndex  =  2 ;
            esta . btnlogin . Text  =  " Ingresar " ;
            esta . btnlogin . UseVisualStyleBackColor  =  true ;
            esta . btnlogin . Haga clic en  + =  nuevo  sistema . EventHandler ( este . BtnLoginClick );
            // 
            // contraseña txt
            // 
            esta . contraseña txt . Ubicación  =  nuevo  sistema . Dibujo . Punto ( 36 , 267 );
            esta . contraseña txt . Nombre  =  " txtPassword " ;
            esta . contraseña txt . PasswordChar  =  '*' ;
            esta . contraseña txt . Tamaño  =  nuevo  sistema . Dibujo . Tamaño ( 218 , 22 );
            esta . contraseña txt . TabIndex  =  1 ;
            // 
            // txtUser
            // 
            esta . txtUser . Ubicación  =  nuevo  sistema . Dibujo . Punto ( 36 , 197 );
            esta . txtUser . Nombre  =  " txtUser " ;
            esta . txtUser . Tamaño  =  nuevo  sistema . Dibujo . Tamaño ( 218 , 22 );
            esta . txtUser . TabIndex  =  0 ;
            // 
            // label1
            // 
            esta . etiqueta1 . Ubicación  =  nuevo  sistema . Dibujo . Punto ( 36 , 171 );
            esta . etiqueta1 . Nombre  =  " label1 " ;
            esta . etiqueta1 . Tamaño  =  nuevo  sistema . Dibujo . Tamaño ( 100 , 23 );
            esta . etiqueta1 . TabIndex  =  3 ;
            esta . etiqueta1 . Text  =  " Usuario: " ;
            // 
            // label2
            // 
            esta . label2 . Ubicación  =  nuevo  sistema . Dibujo . Punto ( 36 , 241 );
            esta . label2 . Nombre  =  " label2 " ;
            esta . label2 . Tamaño  =  nuevo  sistema . Dibujo . Tamaño ( 100 , 23 );
            esta . label2 . TabIndex  =  4 ;
            esta . label2 . Text  =  " Contraseña: " ;
            // 
            // lblRecovery
            // 
            esta . lblRecovery . Ubicación  =  nuevo  sistema . Dibujo . Punto ( 116 , 380 );
            esta . lblRecovery . Nombre  =  " lblRecovery " ;
            esta . lblRecovery . Tamaño  =  nuevo  sistema . Dibujo . Tamaño ( 138 , 23 );
            esta . lblRecovery . TabIndex  =  5 ;
            esta . lblRecovery . Texto  =  " Olvidé mi contraseña " ;
            // 
            // pictureBox1
            // 
            esta . pictureBox1 . Image  = (( System . Drawing . Image ) ( resources . GetObject ( " pictureBox1.Image " )));
            esta . pictureBox1 . Ubicación  =  nuevo  sistema . Dibujo . Punto ( 101 , 41 );
            esta . pictureBox1 . Nombre  =  " pictureBox1 " ;
            esta . pictureBox1 . Tamaño  =  nuevo  sistema . Dibujo . Tamaño ( 89 , 98 );
            esta . pictureBox1 . SizeMode  =  Sistema . Ventanas . Formas . PictureBoxSizeMode . StretchImage ;
            esta . pictureBox1 . TabIndex  =  6 ;
            esta . pictureBox1 . TabStop  =  falso ;
            // 
            // FormLogin
            // 
            esta . AutoScaleDimensions  =  nuevo  sistema . Dibujo . Tamaño F ( 8F , 16F );
            esta . AutoScaleMode  =  Sistema . Ventanas . Formas . AutoScaleMode . Fuente ;
            esta . BackColor  =  Sistema . Dibujo . El color . blanco ;
            esta . ClientSize  =  nuevo  sistema . Dibujo . Tamaño ( 290 , 433 );
            esta . Controles . Añadir ( esto . PictureBox1 );
            esta . Controles . Añadir ( esto . LblRecovery );
            esta . Controles . Añadir ( este . Label2 );
            esta . Controles . Añadir ( esto . Etiqueta1 );
            esta . Controles . Añadir ( este . TxtUser );
            esta . Controles . Añadir ( esto . TxtPassword );
            esta . Controles . Añadir ( este . BtnLogin );
            esta . Fuente  =  nuevo  sistema . Dibujo . Fuente ( " Microsoft Sans Serif " , 9.75F , System . Drawing . FontStyle . Regular , System . Drawing . GraphicsUnit . Point , (( byte ) ( 0 )));
            esta . FormBorderStyle  =  Sistema . Ventanas . Formas . FormBorderStyle . Fixed3D ;
            esta . Margen  =  nuevo  sistema . Ventanas . Formas . Relleno ( 4 );
            esta . MaximizeBox  =  falso ;
            esta . MinimizeBox  =  false ;
            esta . Nombre  =  " FormLogin " ;
            esta . StartPosition  =  Sistema . Ventanas . Formas . FormStartPosition . CenterScreen ;
            esta . Texto  =  " Ingreso " ;
            (( System . ComponentModel . ISupportInitialize ) ( this . PictureBox1 )). EndInit ();
            esta . ResumeLayout ( false );
            esta . PerformLayout ();

		}
	}
}
	
		}
	}
}
