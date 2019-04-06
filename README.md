# EditeurDeText

Présentation du projet: le but est de réaliser un petit éditeur de texte.

Les outils mis en oeuvre :

* git.
* Visual studio.

1. Creation d'un menu déroulant "Fichier" avec le composant "MenuStrip" qui permet:
- d'ouvrir un fichier. 
- crée un niuveau fichier. 
- enregistrer un fichier. 
- enregistrer sous un fichier. 
- quitter l'application. 

<a href="http://www.noelshack.com/2019-14-6-1554566333-img-20190406-095754.jpg"><img src="http://image.noelshack.com/minis/2019/14/6/1554566333-img-20190406-095754.png" border="0" alt="1554566333-img-20190406-095754.jpg - envoi d'image avec NoelShack" title="1554566333-img-20190406-095754.jpg"/></a>

2. Creation d'un menu déroulant "Editer" avec le composant "MenuStrip" qui permet:
- d'Annuler une saisie. 
- Rétablir une saisie. 
- Copier. 
- Coller. 
- Couper. 

<a href="http://www.noelshack.com/2019-14-6-1554565984-img-20190406-095804.jpg"><img src="http://image.noelshack.com/minis/2019/14/6/1554565984-img-20190406-095804.png" border="0" alt="1554565984-img-20190406-095804.jpg - envoi d'image avec NoelShack" title="1554565984-img-20190406-095804.jpg"/></a>

3. Une barre de Recherche.

## Réalisation ##

On utilise le composant "OpenFileDialog" qui permet de récupérer le nom du fichier séléctionné par l'utilisateur.
Il sera donc ensuite possible de charger le contenu de ce fichier dans une richtextbox
il sera aussi possible après un dialogue de sauvegarde de transferer le contenu de notre texte.

- menu Fichier
1. -Bouton ouvrir: Utilisation de la méthode "ShowDialog" qui permet d'afficher le dialogue d'ouverture de fichiers standard.
```cs
{
    if (od_ouvrir.ShowDialog() == DialogResult.OK)
    {
        rt_texte.LoadFile(od_ouvrir.FileName, RichTextBoxStreamType.PlainText);
    }
}
```
2. -Bouton Nouveau 
```cs
{
  rt_texte.Clear();
  enregistrer = false;
}
```
3. -Bouton Enregistrer : "SaveFileDialog"
```cs
{
     rt_texte.SaveFile(sf_save.FileName, RichTextBoxStreamType.PlainText);
}
```
4. -Bouton Enregistrer Sous : Affichage de la fenêtre.
```cs
if (sf_save.ShowDialog() == DialogResult.OK)
    {
         rt_texte.SaveFile(sf_save.FileName, RichTextBoxStreamType.PlainText);
         enregistrer = true;
    }
}
```
5. -Bouton Quitter : Ferme l'application. 
```cs
{
     Application.Exit();
}
```


- menu Editer
1. -Bouton Couper: Utilisation de la méthode "Cut".
```cs
{
   rt_texte.Cut();
}
```
2. -Bouton Coller: Utilisation de la méthode "Copy".
```cs
{
   rt_texte.Copy();
}
```
3. -Bouton Copier: Utilisation de la méthode "Paste".
```cs
{
   rt_texte.Paste();
}
```
4. -Bouton Annuler: Utilisation de la méthode "Undo".
```cs
{
   rt_texte.Undo();
}
```
5. -Bouton Rétablir: Utilisation de la méthode "Redo".
```cs
{
   rt_texte.Redo();
}
```


## Rendu Final ##
![EditeurText.png](http://image.noelshack.com/fichiers/2019/14/6/1554537607-capture.png)
