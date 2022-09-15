using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;

namespace DevComponents.DotNetBar;

public class DocumentDockUIManager
{
	private DocumentDockContainer documentDockContainer_0;

	private Cursor cursor_0;

	private DockSite dockSite_0;

	private Point point_0 = Point.Empty;

	private bool bool_0;

	private Form form_0;

	private DocumentDockContainer documentDockContainer_1;

	private DocumentBaseContainer documentBaseContainer_0;

	private int int_0 = 3;

	private bool bool_1;

	public DocumentDockContainer RootDocumentDockContainer
	{
		get
		{
			return documentDockContainer_0;
		}
		set
		{
			documentDockContainer_0 = value;
		}
	}

	public DockSite Container
	{
		get
		{
			return dockSite_0;
		}
		set
		{
			dockSite_0 = value;
		}
	}

	public bool IsResizingDocument => documentBaseContainer_0 != null;

	public DocumentDockUIManager(DockSite container)
	{
		dockSite_0 = container;
	}

	internal Rectangle method_0(Bar bar_0, ref DockSiteInfo dockSiteInfo_0)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Invalid comparison between Unknown and I4
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Invalid comparison between Unknown and I4
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Invalid comparison between Unknown and I4
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Invalid comparison between Unknown and I4
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Invalid comparison between Unknown and I4
		//IL_0270: Unknown result type (might be due to invalid IL or missing references)
		//IL_0276: Invalid comparison between Unknown and I4
		DocumentBaseContainer documentFromBar = GetDocumentFromBar(dockSiteInfo_0.MouseOverBar);
		Rectangle result = Rectangle.Empty;
		if ((int)((Control)dockSite_0).get_Dock() != 5 && (dockSiteInfo_0.DockLine == 999 || dockSiteInfo_0.DockLine == -1))
		{
			return method_1(bar_0, ref dockSiteInfo_0);
		}
		if (documentFromBar != null)
		{
			if (dockSiteInfo_0.MouseOverDockSide == eDockSide.Left)
			{
				result = documentFromBar.DisplayBounds;
				result.Width /= 2;
			}
			else if (dockSiteInfo_0.MouseOverDockSide == eDockSide.Right)
			{
				result = documentFromBar.DisplayBounds;
				result.X += result.Width / 2;
				result.Width /= 2;
			}
			else if (dockSiteInfo_0.MouseOverDockSide == eDockSide.Top)
			{
				result = documentFromBar.DisplayBounds;
				result.Height /= 2;
			}
			else if (dockSiteInfo_0.MouseOverDockSide == eDockSide.Bottom)
			{
				result = documentFromBar.DisplayBounds;
				result.Y += result.Height / 2;
				result.Height /= 2;
			}
			else if (dockSiteInfo_0.MouseOverDockSide == eDockSide.Document)
			{
				result = documentFromBar.DisplayBounds;
			}
			result.Location = ((Control)dockSite_0).PointToScreen(result.Location);
		}
		else if ((int)((Control)dockSite_0).get_Dock() == 5)
		{
			result = ((Control)dockSite_0).get_ClientRectangle();
			result.Location = ((Control)dockSite_0).PointToScreen(result.Location);
		}
		else if ((int)((Control)dockSite_0).get_Dock() == 4)
		{
			result = ((Control)dockSite_0).get_ClientRectangle();
			result.Location = ((Control)dockSite_0).PointToScreen(result.Location);
			if (result.Width == 0)
			{
				result.Width = bar_0.method_135(eOrientation.Vertical);
				result.X -= result.Width;
			}
		}
		else if ((int)((Control)dockSite_0).get_Dock() == 3)
		{
			result = ((Control)dockSite_0).get_ClientRectangle();
			result.Location = ((Control)dockSite_0).PointToScreen(result.Location);
			if (result.Width == 0)
			{
				result.Width = bar_0.method_135(eOrientation.Vertical);
			}
		}
		else if ((int)((Control)dockSite_0).get_Dock() == 1)
		{
			result = ((Control)dockSite_0).get_ClientRectangle();
			result.Location = ((Control)dockSite_0).PointToScreen(result.Location);
			if (result.Height == 0)
			{
				result.Height = bar_0.method_135(eOrientation.Horizontal);
			}
		}
		else if ((int)((Control)dockSite_0).get_Dock() == 2)
		{
			result = ((Control)dockSite_0).get_ClientRectangle();
			result.Location = ((Control)dockSite_0).PointToScreen(result.Location);
			if (result.Height == 0)
			{
				result.Height = bar_0.method_135(eOrientation.Horizontal);
				result.Y -= result.Height;
			}
		}
		return result;
	}

	private Rectangle method_1(Bar bar_0, ref DockSiteInfo dockSiteInfo_0)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected I4, but got Unknown
		Rectangle empty = Rectangle.Empty;
		int num = -1;
		int num2 = -1;
		if (dockSiteInfo_0.FullSizeDock)
		{
			num = dockSite_0.method_20();
		}
		else if (dockSiteInfo_0.PartialSizeDock)
		{
			num2 = dockSite_0.method_19();
		}
		DockStyle dock = ((Control)dockSite_0).get_Dock();
		switch (dock - 1)
		{
		case 0:
		{
			empty.Width = ((Control)dockSite_0).get_ClientRectangle().Width;
			empty.Height = bar_0.method_135(eOrientation.Horizontal);
			if (num >= 0)
			{
				empty.Width += dockSite_0.method_18(dockSite_0.Owner.LeftDockSite, bool_8: true).Width;
				empty.Width += dockSite_0.method_18(dockSite_0.Owner.RightDockSite, bool_8: true).Width;
				dockSiteInfo_0.DockSiteZOrderIndex = num;
			}
			else if (num2 >= 0)
			{
				empty.Width -= dockSite_0.method_18(dockSite_0.Owner.LeftDockSite, bool_8: false).Width;
				empty.Width -= dockSite_0.method_18(dockSite_0.Owner.RightDockSite, bool_8: false).Width;
				dockSiteInfo_0.DockSiteZOrderIndex = num2;
			}
			Point empty4 = Point.Empty;
			if (dockSiteInfo_0.DockLine == -1)
			{
				empty4 = ((Control)dockSite_0).PointToScreen(((Control)dockSite_0).get_ClientRectangle().Location);
			}
			else
			{
				empty4 = ((Control)dockSite_0).PointToScreen(new Point(((Control)dockSite_0).get_ClientRectangle().X, ((Control)dockSite_0).get_ClientRectangle().Bottom));
				empty4.Y++;
			}
			if (num >= 0)
			{
				empty4.X -= dockSite_0.method_18(dockSite_0.Owner.LeftDockSite, bool_8: true).Width;
			}
			else if (num2 >= 0)
			{
				empty4.X += dockSite_0.method_18(dockSite_0.Owner.LeftDockSite, bool_8: false).Width;
			}
			empty.Location = empty4;
			break;
		}
		case 1:
		{
			empty.Width = ((Control)dockSite_0).get_ClientRectangle().Width;
			empty.Height = bar_0.method_135(eOrientation.Horizontal);
			if (num >= 0)
			{
				empty.Width += dockSite_0.method_18(dockSite_0.Owner.LeftDockSite, bool_8: true).Width;
				empty.Width += dockSite_0.method_18(dockSite_0.Owner.RightDockSite, bool_8: true).Width;
				dockSiteInfo_0.DockSiteZOrderIndex = num;
			}
			else if (num2 >= 0)
			{
				empty.Width -= dockSite_0.method_18(dockSite_0.Owner.LeftDockSite, bool_8: false).Width;
				empty.Width -= dockSite_0.method_18(dockSite_0.Owner.RightDockSite, bool_8: false).Width;
				dockSiteInfo_0.DockSiteZOrderIndex = num2;
			}
			Point empty3 = Point.Empty;
			if (dockSiteInfo_0.DockLine == -1)
			{
				empty3 = ((Control)dockSite_0).PointToScreen(new Point(((Control)dockSite_0).get_ClientRectangle().X, ((Control)dockSite_0).get_ClientRectangle().Y - empty.Height));
			}
			else
			{
				empty3 = ((Control)dockSite_0).PointToScreen(new Point(((Control)dockSite_0).get_ClientRectangle().X, ((Control)dockSite_0).get_ClientRectangle().Bottom - empty.Height));
				empty3.Y++;
			}
			if (num >= 0)
			{
				empty3.X -= dockSite_0.method_18(dockSite_0.Owner.LeftDockSite, bool_8: true).Width;
			}
			else if (num2 >= 0)
			{
				empty3.X += dockSite_0.method_18(dockSite_0.Owner.LeftDockSite, bool_8: false).Width;
			}
			empty.Location = empty3;
			break;
		}
		default:
		{
			empty.Height = ((Control)dockSite_0).get_ClientRectangle().Height;
			if (num >= 0)
			{
				empty.Height += dockSite_0.method_18(dockSite_0.Owner.TopDockSite, bool_8: true).Height;
				empty.Height += dockSite_0.method_18(dockSite_0.Owner.BottomDockSite, bool_8: true).Height;
				dockSiteInfo_0.DockSiteZOrderIndex = num;
			}
			else if (num2 >= 0)
			{
				empty.Height -= dockSite_0.method_18(dockSite_0.Owner.TopDockSite, bool_8: false).Height;
				empty.Height -= dockSite_0.method_18(dockSite_0.Owner.BottomDockSite, bool_8: false).Height;
				dockSiteInfo_0.DockSiteZOrderIndex = num2;
			}
			empty.Width = bar_0.method_135(eOrientation.Vertical);
			Point empty5 = Point.Empty;
			if (dockSiteInfo_0.DockLine == -1)
			{
				empty5 = ((Control)dockSite_0).PointToScreen(new Point(((Control)dockSite_0).get_ClientRectangle().X, ((Control)dockSite_0).get_ClientRectangle().Y));
			}
			else
			{
				empty5 = ((Control)dockSite_0).PointToScreen(new Point(((Control)dockSite_0).get_ClientRectangle().Right, ((Control)dockSite_0).get_ClientRectangle().Y));
				empty5.X++;
			}
			if (num >= 0)
			{
				empty5.Y -= dockSite_0.method_18(dockSite_0.Owner.TopDockSite, bool_8: true).Height;
			}
			else if (num2 >= 0)
			{
				empty5.Y += dockSite_0.method_18(dockSite_0.Owner.TopDockSite, bool_8: false).Height;
			}
			empty.Location = empty5;
			break;
		}
		case 3:
		{
			empty.Height = ((Control)dockSite_0).get_ClientRectangle().Height;
			if (num >= 0)
			{
				empty.Height += dockSite_0.method_18(dockSite_0.Owner.TopDockSite, bool_8: true).Height;
				empty.Height += dockSite_0.method_18(dockSite_0.Owner.BottomDockSite, bool_8: true).Height;
				dockSiteInfo_0.DockSiteZOrderIndex = num;
			}
			else if (num2 >= 0)
			{
				empty.Height -= dockSite_0.method_18(dockSite_0.Owner.TopDockSite, bool_8: false).Height;
				empty.Height -= dockSite_0.method_18(dockSite_0.Owner.BottomDockSite, bool_8: false).Height;
				dockSiteInfo_0.DockSiteZOrderIndex = num2;
			}
			empty.Width = bar_0.method_135(eOrientation.Vertical);
			Point empty2 = Point.Empty;
			if (dockSiteInfo_0.DockLine == -1)
			{
				empty2 = ((Control)dockSite_0).PointToScreen(new Point(((Control)dockSite_0).get_ClientRectangle().X - empty.Width, ((Control)dockSite_0).get_ClientRectangle().Y));
			}
			else
			{
				empty2 = ((Control)dockSite_0).PointToScreen(new Point(((Control)dockSite_0).get_ClientRectangle().Right - empty.Width, ((Control)dockSite_0).get_ClientRectangle().Y));
				empty2.X--;
			}
			if (num >= 0)
			{
				empty2.Y -= dockSite_0.method_18(dockSite_0.Owner.TopDockSite, bool_8: true).Height;
			}
			else if (num2 >= 0)
			{
				empty2.Y += dockSite_0.method_18(dockSite_0.Owner.TopDockSite, bool_8: false).Height;
			}
			empty.Location = empty2;
			break;
		}
		}
		return empty;
	}

	public DocumentBaseContainer GetDocumentFromBar(Bar bar)
	{
		if (bar == null)
		{
			return null;
		}
		return method_2(bar, documentDockContainer_0);
	}

	private DocumentBaseContainer method_2(Bar bar_0, DocumentDockContainer documentDockContainer_2)
	{
		foreach (DocumentBaseContainer document in documentDockContainer_2.Documents)
		{
			if (!(document is DocumentBarContainer) || ((DocumentBarContainer)document).Bar != bar_0)
			{
				if (document is DocumentDockContainer)
				{
					DocumentBaseContainer documentBaseContainer2 = method_2(bar_0, document as DocumentDockContainer);
					if (documentBaseContainer2 != null)
					{
						return documentBaseContainer2;
					}
				}
				continue;
			}
			return document;
		}
		return null;
	}

	private bool method_3(eDockSide eDockSide_0)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Invalid comparison between Unknown and I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Invalid comparison between Unknown and I4
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Invalid comparison between Unknown and I4
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Invalid comparison between Unknown and I4
		if (((int)((Control)dockSite_0).get_Dock() == 3 && eDockSide_0 == eDockSide.Left) || ((int)((Control)dockSite_0).get_Dock() == 4 && eDockSide_0 == eDockSide.Left) || ((int)((Control)dockSite_0).get_Dock() == 1 && eDockSide_0 == eDockSide.Top) || ((int)((Control)dockSite_0).get_Dock() == 2 && eDockSide_0 == eDockSide.Top))
		{
			return true;
		}
		return false;
	}

	public void Dock(Bar barToDock)
	{
		Dock(null, barToDock, eDockSide.None);
	}

	public void Dock(Bar referenceBar, Bar barToDock, eDockSide dockSide)
	{
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Invalid comparison between Unknown and I4
		//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Invalid comparison between Unknown and I4
		//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Invalid comparison between Unknown and I4
		if (dockSide == eDockSide.None && ((Control)barToDock).get_Parent() == dockSite_0)
		{
			method_9(barToDock);
			return;
		}
		if (((Control)barToDock).get_Parent() is DockSite && ((DockSite)(object)((Control)barToDock).get_Parent()).DocumentDockContainer != null)
		{
			((DockSite)(object)((Control)barToDock).get_Parent()).GetDocumentUIManager().UnDock(barToDock);
		}
		else if (((Control)barToDock).get_Parent() is DockSite && ((Control)barToDock).get_Parent() != dockSite_0)
		{
			((DockSite)(object)((Control)barToDock).get_Parent()).method_21((Control)(object)barToDock);
		}
		else if (((Control)barToDock).get_Parent() != null && ((Control)barToDock).get_Parent() != dockSite_0)
		{
			if (((Control)barToDock).get_Parent() is Form0)
			{
				barToDock.method_41();
				barToDock.method_88(eBarState.Docked);
			}
			else
			{
				((Control)barToDock).get_Parent().get_Controls().Remove((Control)(object)barToDock);
			}
		}
		if (!bool_1)
		{
			DocumentBarContainer documentBarContainer = method_11(barToDock);
			DocumentBaseContainer documentFromBar = GetDocumentFromBar(referenceBar);
			if (referenceBar != null && dockSide != 0 && referenceBar != barToDock && documentFromBar != null)
			{
				DocumentDockContainer documentDockContainer = documentFromBar.Parent as DocumentDockContainer;
				documentFromBar.method_1(Rectangle.Empty);
				documentBarContainer.method_1(Rectangle.Empty);
				if ((documentDockContainer.Orientation == eOrientation.Horizontal && (dockSide == eDockSide.Left || dockSide == eDockSide.Right)) || (documentDockContainer.Orientation == eOrientation.Vertical && (dockSide == eDockSide.Top || dockSide == eDockSide.Bottom)))
				{
					if (dockSide != eDockSide.Right && dockSide != eDockSide.Bottom)
					{
						documentDockContainer.Documents.Insert(documentDockContainer.Documents.IndexOf(documentFromBar), documentBarContainer);
					}
					else
					{
						documentDockContainer.Documents.Insert(documentDockContainer.Documents.IndexOf(documentFromBar) + 1, documentBarContainer);
					}
				}
				else if (documentDockContainer.Documents.Count == 1)
				{
					if (documentDockContainer.Orientation == eOrientation.Vertical)
					{
						documentDockContainer.Orientation = eOrientation.Horizontal;
					}
					else
					{
						documentDockContainer.Orientation = eOrientation.Vertical;
					}
					if (dockSide != eDockSide.Right && dockSide != eDockSide.Bottom)
					{
						documentDockContainer.Documents.Insert(documentDockContainer.Documents.IndexOf(documentFromBar), documentBarContainer);
					}
					else
					{
						documentDockContainer.Documents.Insert(documentDockContainer.Documents.IndexOf(documentFromBar) + 1, documentBarContainer);
					}
				}
				else
				{
					DocumentDockContainer documentDockContainer2 = new DocumentDockContainer();
					if (documentDockContainer.Orientation == eOrientation.Horizontal)
					{
						documentDockContainer2.Orientation = eOrientation.Vertical;
					}
					else
					{
						documentDockContainer2.Orientation = eOrientation.Horizontal;
					}
					documentDockContainer.Documents.Insert(documentDockContainer.Documents.IndexOf(documentFromBar), documentDockContainer2);
					documentDockContainer.Documents.Remove(documentFromBar);
					if (dockSide != eDockSide.Right && dockSide != eDockSide.Bottom)
					{
						documentDockContainer2.Documents.Add(documentBarContainer);
						documentDockContainer2.Documents.Add(documentFromBar);
					}
					else
					{
						documentDockContainer2.Documents.Add(documentFromBar);
						documentDockContainer2.Documents.Add(documentBarContainer);
					}
				}
			}
			else if ((int)((Control)dockSite_0).get_Dock() == 5)
			{
				documentDockContainer_0.Documents.Add(documentBarContainer);
			}
			else
			{
				eOrientation eOrientation2 = eOrientation.Horizontal;
				if ((int)((Control)dockSite_0).get_Dock() == 1 || (int)((Control)dockSite_0).get_Dock() == 2)
				{
					eOrientation2 = eOrientation.Vertical;
				}
				if (documentDockContainer_0.Orientation != eOrientation2)
				{
					if (documentDockContainer_0.Documents.Count <= 1)
					{
						documentDockContainer_0.Orientation = eOrientation2;
						if (method_3(dockSide))
						{
							documentDockContainer_0.Documents.Insert(0, documentBarContainer);
						}
						else
						{
							documentDockContainer_0.Documents.Add(documentBarContainer);
						}
					}
					else
					{
						DocumentBaseContainer[] array = new DocumentBaseContainer[documentDockContainer_0.Documents.Count];
						documentDockContainer_0.Documents.method_0(array);
						documentDockContainer_0.Documents.Clear();
						DocumentDockContainer documentDockContainer3 = new DocumentDockContainer(array, documentDockContainer_0.Orientation);
						documentDockContainer3.method_1(documentDockContainer_0.DisplayBounds);
						documentDockContainer_0.Orientation = eOrientation2;
						documentDockContainer_0.Documents.Add(documentDockContainer3);
						if (method_3(dockSide))
						{
							documentDockContainer_0.Documents.Insert(0, documentBarContainer);
						}
						else
						{
							documentDockContainer_0.Documents.Add(documentBarContainer);
						}
					}
				}
				else if (method_3(dockSide))
				{
					documentDockContainer_0.Documents.Insert(0, documentBarContainer);
				}
				else
				{
					documentDockContainer_0.Documents.Add(documentBarContainer);
				}
			}
			method_4(barToDock, bool_2: false);
		}
		if (dockSite_0 != null)
		{
			if (((Control)barToDock).get_Parent() == null)
			{
				((Control)dockSite_0).get_Controls().Add((Control)(object)barToDock);
			}
			method_9(barToDock);
			dockSite_0.RecalcLayout();
		}
		else
		{
			method_9(barToDock);
		}
	}

	internal void method_4(Bar bar_0, bool bool_2)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Invalid comparison between Unknown and I4
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Invalid comparison between Unknown and I4
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Invalid comparison between Unknown and I4
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Invalid comparison between Unknown and I4
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Invalid comparison between Unknown and I4
		if ((dockSite_0.Owner != null && dockSite_0.Owner.IsLoadingLayout) || (int)((Control)dockSite_0).get_Dock() == 5)
		{
			return;
		}
		DocumentBaseContainer documentFromBar = GetDocumentFromBar(bar_0);
		if (documentFromBar == null)
		{
			return;
		}
		if ((int)((Control)dockSite_0).get_Dock() != 3 && (int)((Control)dockSite_0).get_Dock() != 4)
		{
			if (((int)((Control)dockSite_0).get_Dock() != 1 && (int)((Control)dockSite_0).get_Dock() != 2) || (((Control)dockSite_0).get_Height() != 0 && (documentFromBar.Parent != documentDockContainer_0 || (documentDockContainer_0.Orientation != eOrientation.Vertical && (!bool_2 || documentDockContainer_0.Documents.Count != 1)))))
			{
				return;
			}
			int num = bar_0.method_135(eOrientation.Horizontal);
			if (((Control)bar_0).get_Height() > 0 && ((Control)bar_0).get_Height() < ((Control)dockSite_0).get_Height())
			{
				num = ((Control)bar_0).get_Height();
			}
			int num2 = method_6();
			if (num > num2)
			{
				num = bar_0.MinimumDockSize(eOrientation.Horizontal).Height * 2;
			}
			if (num > num2)
			{
				num = bar_0.MinimumDockSize(eOrientation.Horizontal).Height;
			}
			if (documentFromBar.LayoutBounds.Height == 0)
			{
				documentFromBar.method_1(new Rectangle(documentFromBar.LayoutBounds.X, documentFromBar.LayoutBounds.Y, documentFromBar.LayoutBounds.Width, num));
			}
			num += documentDockContainer_0.SplitterSize;
			if (bool_2)
			{
				if (bar_0.Visible)
				{
					DockSite dockSite = dockSite_0;
					((Control)dockSite).set_Height(((Control)dockSite).get_Height() + num);
				}
				else if (((Control)dockSite_0).get_Height() > 0)
				{
					DockSite dockSite2 = dockSite_0;
					((Control)dockSite2).set_Height(((Control)dockSite2).get_Height() - Math.Min(num, ((Control)dockSite_0).get_Height()));
				}
			}
			else
			{
				DockSite dockSite3 = dockSite_0;
				((Control)dockSite3).set_Height(((Control)dockSite3).get_Height() + num);
			}
			((Control)dockSite_0).Invalidate();
		}
		else
		{
			if (((Control)dockSite_0).get_Width() != 0 && (documentFromBar.Parent != documentDockContainer_0 || (documentDockContainer_0.Orientation != 0 && (!bool_2 || documentDockContainer_0.Documents.Count != 1))))
			{
				return;
			}
			int num3 = bar_0.method_135(eOrientation.Vertical);
			if (((Control)bar_0).get_Width() > 0 && ((Control)bar_0).get_Width() < ((Control)dockSite_0).get_Width())
			{
				num3 = ((Control)bar_0).get_Width();
			}
			int num4 = method_5();
			if (num3 > num4)
			{
				num3 = bar_0.MinimumDockSize(eOrientation.Vertical).Width * 2;
			}
			if (num3 > num4)
			{
				num3 = bar_0.MinimumDockSize(eOrientation.Vertical).Width;
			}
			if (documentFromBar.LayoutBounds.Width == 0)
			{
				documentFromBar.method_1(new Rectangle(documentFromBar.LayoutBounds.X, documentFromBar.LayoutBounds.Y, num3, documentFromBar.LayoutBounds.Height));
			}
			num3 += documentDockContainer_0.SplitterSize;
			if (bool_2)
			{
				if (bar_0.Visible)
				{
					DockSite dockSite4 = dockSite_0;
					((Control)dockSite4).set_Width(((Control)dockSite4).get_Width() + num3);
				}
				else if (((Control)dockSite_0).get_Width() > 0)
				{
					DockSite dockSite5 = dockSite_0;
					((Control)dockSite5).set_Width(((Control)dockSite5).get_Width() - Math.Min(num3, ((Control)dockSite_0).get_Width()));
				}
			}
			else
			{
				DockSite dockSite6 = dockSite_0;
				((Control)dockSite6).set_Width(((Control)dockSite6).get_Width() + num3);
			}
			((Control)dockSite_0).Invalidate();
		}
	}

	private int method_5()
	{
		if (dockSite_0 == null)
		{
			return 0;
		}
		return dockSite_0.method_11();
	}

	private int method_6()
	{
		if (dockSite_0 == null)
		{
			return 0;
		}
		return dockSite_0.method_12();
	}

	public void UnDock(Bar barToUnDock)
	{
		method_7(barToUnDock, bool_2: true);
	}

	internal void method_7(Bar bar_0, bool bool_2)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Invalid comparison between Unknown and I4
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Invalid comparison between Unknown and I4
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Invalid comparison between Unknown and I4
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Invalid comparison between Unknown and I4
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Invalid comparison between Unknown and I4
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Invalid comparison between Unknown and I4
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Invalid comparison between Unknown and I4
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Invalid comparison between Unknown and I4
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Invalid comparison between Unknown and I4
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Invalid comparison between Unknown and I4
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_0239: Invalid comparison between Unknown and I4
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Invalid comparison between Unknown and I4
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Invalid comparison between Unknown and I4
		DocumentBarContainer barDocumentContainer = documentDockContainer_0.GetBarDocumentContainer(bar_0);
		int num = 0;
		if (barDocumentContainer != null && dockSite_0 != null && (int)((Control)dockSite_0).get_Dock() != 5)
		{
			if ((int)((Control)dockSite_0).get_Dock() != 3 && (int)((Control)dockSite_0).get_Dock() != 4)
			{
				if (((int)((Control)dockSite_0).get_Dock() == 1 || (int)((Control)dockSite_0).get_Dock() == 2) && barDocumentContainer.Parent != null && barDocumentContainer.Parent == documentDockContainer_0 && documentDockContainer_0.Orientation == eOrientation.Vertical)
				{
					num = ((Control)bar_0).get_Height() + documentDockContainer_0.SplitterSize;
				}
			}
			else if (barDocumentContainer.Parent != null && barDocumentContainer.Parent == documentDockContainer_0 && documentDockContainer_0.Orientation == eOrientation.Horizontal)
			{
				num = ((Control)bar_0).get_Width() + documentDockContainer_0.SplitterSize;
			}
		}
		if (barDocumentContainer == null)
		{
			if (bool_2 && ((Control)bar_0).get_Parent() == dockSite_0)
			{
				((Control)dockSite_0).get_Controls().Remove((Control)(object)bar_0);
			}
			method_10(bar_0);
			return;
		}
		if (barDocumentContainer.Parent is DocumentDockContainer documentDockContainer)
		{
			documentDockContainer.Documents.Remove(barDocumentContainer);
			if (documentDockContainer != documentDockContainer_0)
			{
				method_8(documentDockContainer);
			}
			else if (documentDockContainer.Documents.Count == 1 && documentDockContainer.Documents[0] is DocumentDockContainer)
			{
				method_8(documentDockContainer.Documents[0] as DocumentDockContainer);
			}
		}
		if (dockSite_0 != null)
		{
			if (bool_2)
			{
				((Control)dockSite_0).get_Controls().Remove((Control)(object)bar_0);
			}
			method_10(bar_0);
			bool flag = false;
			if (dockSite_0.Owner != null)
			{
				flag = dockSite_0.Owner.IsLoadingLayout;
			}
			if (!flag && !dockSite_0.Boolean_0)
			{
				if ((int)((Control)dockSite_0).get_Dock() != 3 && (int)((Control)dockSite_0).get_Dock() != 4)
				{
					if ((int)((Control)dockSite_0).get_Dock() == 1 || (int)((Control)dockSite_0).get_Dock() == 2)
					{
						((Control)dockSite_0).set_Height(0);
					}
				}
				else
				{
					((Control)dockSite_0).set_Width(0);
				}
			}
			else if (!flag && num != 0)
			{
				if ((int)((Control)dockSite_0).get_Dock() != 3 && (int)((Control)dockSite_0).get_Dock() != 4)
				{
					if ((int)((Control)dockSite_0).get_Dock() == 1 || (int)((Control)dockSite_0).get_Dock() == 2)
					{
						DockSite dockSite = dockSite_0;
						((Control)dockSite).set_Height(((Control)dockSite).get_Height() - num);
					}
				}
				else
				{
					DockSite dockSite2 = dockSite_0;
					((Control)dockSite2).set_Width(((Control)dockSite2).get_Width() - num);
				}
			}
			else
			{
				dockSite_0.RecalcLayout();
			}
		}
		else
		{
			method_10(bar_0);
		}
	}

	private void method_8(DocumentDockContainer documentDockContainer_2)
	{
		while ((documentDockContainer_2.Documents.Count == 0 && documentDockContainer_2.Parent != null && documentDockContainer_2.Parent is DocumentDockContainer) || (documentDockContainer_2.Parent != null && documentDockContainer_2.Parent is DocumentDockContainer && ((DocumentDockContainer)documentDockContainer_2.Parent).Documents.Count == 1))
		{
			if (documentDockContainer_2.Parent != null && documentDockContainer_2.Parent is DocumentDockContainer && ((DocumentDockContainer)documentDockContainer_2.Parent).Documents.Count == 1)
			{
				DocumentDockContainer documentDockContainer = documentDockContainer_2.Parent as DocumentDockContainer;
				documentDockContainer.Documents.Remove(documentDockContainer_2);
				documentDockContainer.Orientation = documentDockContainer_2.Orientation;
				DocumentBaseContainer[] array = new DocumentBaseContainer[documentDockContainer_2.Documents.Count];
				documentDockContainer_2.Documents.method_0(array);
				documentDockContainer.Documents.AddRange(array);
				documentDockContainer_2 = documentDockContainer;
			}
			else
			{
				DocumentDockContainer documentDockContainer2 = documentDockContainer_2.Parent as DocumentDockContainer;
				documentDockContainer2.Documents.Remove(documentDockContainer_2);
				documentDockContainer_2 = documentDockContainer2;
			}
		}
	}

	private void method_9(Bar bar_0)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Invalid comparison between Unknown and I4
		if (dockSite_0 != null && dockSite_0.Owner != null && dockSite_0.Owner.ApplyDocumentBarStyle && (int)((Control)dockSite_0).get_Dock() == 5)
		{
			Class109.smethod_9(bar_0);
		}
	}

	private void method_10(Bar bar_0)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Invalid comparison between Unknown and I4
		if (dockSite_0 != null && dockSite_0.Owner != null && dockSite_0.Owner.ApplyDocumentBarStyle && (int)((Control)dockSite_0).get_Dock() == 5)
		{
			Class109.smethod_10(bar_0);
		}
	}

	private DocumentBarContainer method_11(Bar bar_0)
	{
		return new DocumentBarContainer(bar_0);
	}

	private DocumentDockContainer method_12()
	{
		return new DocumentDockContainer();
	}

	public void OnMouseMove(MouseEventArgs e)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Invalid comparison between Unknown and I4
		int x = e.get_X();
		int y = e.get_Y();
		if ((int)e.get_Button() == 0)
		{
			Cursor val = method_13(x, y);
			if (val == (Cursor)null)
			{
				if (cursor_0 != (Cursor)null)
				{
					((Control)Container).set_Cursor(cursor_0);
				}
				cursor_0 = null;
			}
			else
			{
				if (cursor_0 == (Cursor)null)
				{
					cursor_0 = ((Control)Container).get_Cursor();
				}
				((Control)Container).set_Cursor(val);
			}
		}
		else
		{
			if ((int)e.get_Button() != 1048576)
			{
				return;
			}
			Point point = method_21(x, y);
			if (!point.IsEmpty)
			{
				if (!bool_0)
				{
					method_18(point.X, point.Y);
					return;
				}
				method_23(point.X, point.Y);
				point_0 = point;
			}
		}
	}

	internal Cursor method_13(int int_1, int int_2)
	{
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Invalid comparison between Unknown and I4
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Invalid comparison between Unknown and I4
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Invalid comparison between Unknown and I4
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Invalid comparison between Unknown and I4
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Invalid comparison between Unknown and I4
		Cursor result = null;
		DocumentDockContainer documentDockContainer = method_15(int_1, int_2);
		if (documentDockContainer != null)
		{
			if (documentDockContainer.Orientation == eOrientation.Horizontal)
			{
				result = Cursors.get_VSplit();
			}
			else if (documentDockContainer.Orientation == eOrientation.Vertical)
			{
				result = Cursors.get_HSplit();
			}
		}
		else if (dockSite_0 != null && (int)((Control)dockSite_0).get_Dock() != 5)
		{
			if ((int)((Control)dockSite_0).get_Dock() != 1 && (int)((Control)dockSite_0).get_Dock() != 2)
			{
				if ((int)((Control)dockSite_0).get_Dock() == 3 || (int)((Control)dockSite_0).get_Dock() == 4)
				{
					result = Cursors.get_VSplit();
				}
			}
			else
			{
				result = Cursors.get_HSplit();
			}
		}
		return result;
	}

	public void OnMouseDown(MouseEventArgs e)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Invalid comparison between Unknown and I4
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Invalid comparison between Unknown and I4
		int x = e.get_X();
		int y = e.get_Y();
		if ((int)e.get_Button() != 1048576)
		{
			return;
		}
		point_0 = new Point(x, y);
		DocumentDockContainer documentDockContainer = method_15(x, y);
		if (documentDockContainer != null)
		{
			documentBaseContainer_0 = method_14(documentDockContainer, x, y);
			if (documentBaseContainer_0 != null)
			{
				documentDockContainer_1 = documentDockContainer;
				if (!bool_0)
				{
					method_17();
					method_18(x, y);
				}
			}
		}
		else if (dockSite_0 != null && (int)((Control)dockSite_0).get_Dock() != 5)
		{
			documentDockContainer_1 = documentDockContainer_0;
			if (!bool_0)
			{
				method_17();
				method_18(x, y);
			}
		}
	}

	public void OnMouseUp(MouseEventArgs e)
	{
		if (documentDockContainer_1 != null && !point_0.IsEmpty)
		{
			method_23(e.get_X(), e.get_Y());
		}
		point_0 = Point.Empty;
		documentDockContainer_1 = null;
		documentBaseContainer_0 = null;
		method_19();
	}

	public void OnMouseLeave()
	{
		if (cursor_0 != (Cursor)null)
		{
			((Control)Container).set_Cursor(cursor_0);
		}
		cursor_0 = null;
	}

	private DocumentBaseContainer method_14(DocumentDockContainer documentDockContainer_2, int int_1, int int_2)
	{
		DocumentBaseContainer result = null;
		eOrientation orientation = documentDockContainer_2.Orientation;
		foreach (DocumentBaseContainer document in documentDockContainer_2.Documents)
		{
			if (orientation != 0 || document.DisplayBounds.X <= int_1)
			{
				if (orientation != eOrientation.Vertical || document.DisplayBounds.Y <= int_2)
				{
					result = document;
					continue;
				}
				return result;
			}
			return result;
		}
		return result;
	}

	private DocumentDockContainer method_15(int int_1, int int_2)
	{
		return method_16(documentDockContainer_0, int_1, int_2);
	}

	private DocumentDockContainer method_16(DocumentDockContainer documentDockContainer_2, int int_1, int int_2)
	{
		if (documentDockContainer_2 != null && documentDockContainer_2.DisplayBounds.Contains(int_1, int_2))
		{
			DocumentDockContainer documentDockContainer = null;
			foreach (DocumentBaseContainer document in documentDockContainer_2.Documents)
			{
				if (document is DocumentDockContainer)
				{
					documentDockContainer = method_16((DocumentDockContainer)document, int_1, int_2);
					if (documentDockContainer != null)
					{
						break;
					}
				}
			}
			if (documentDockContainer == null)
			{
				documentDockContainer = documentDockContainer_2;
			}
			return documentDockContainer;
		}
		return null;
	}

	private void method_17()
	{
		if (documentDockContainer_1 != null && form_0 == null)
		{
			form_0 = Class109.smethod_15();
		}
	}

	private void method_18(int int_1, int int_2)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Invalid comparison between Unknown and I4
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Invalid comparison between Unknown and I4
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Invalid comparison between Unknown and I4
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Invalid comparison between Unknown and I4
		if (form_0 != null && documentDockContainer_1 != null)
		{
			Rectangle empty = Rectangle.Empty;
			if ((documentDockContainer_1.Orientation == eOrientation.Horizontal && documentBaseContainer_0 != null) || (documentBaseContainer_0 == null && ((int)((Control)dockSite_0).get_Dock() == 3 || (int)((Control)dockSite_0).get_Dock() == 4)))
			{
				Point point = ((Control)dockSite_0).PointToScreen(new Point(int_1 - int_0 / 2, documentDockContainer_1.DisplayBounds.Y));
				empty.X = point.X;
				empty.Y = point.Y;
				empty.Height = documentDockContainer_1.DisplayBounds.Height;
				empty.Width = int_0;
			}
			else if ((documentDockContainer_1.Orientation == eOrientation.Vertical && documentBaseContainer_0 != null) || (documentBaseContainer_0 == null && ((int)((Control)dockSite_0).get_Dock() == 2 || (int)((Control)dockSite_0).get_Dock() == 1)))
			{
				Point point2 = ((Control)dockSite_0).PointToScreen(new Point(documentDockContainer_1.DisplayBounds.X, int_2 - int_0 / 2));
				empty.X = point2.X;
				empty.Y = point2.Y;
				empty.Width = documentDockContainer_1.DisplayBounds.Width;
				empty.Height = int_0;
			}
			Class92.SetWindowPos(((Control)form_0).get_Handle(), 0, empty.X, empty.Y, empty.Width, empty.Height, 80);
		}
	}

	private void method_19()
	{
		if (form_0 != null)
		{
			((Control)form_0).set_Visible(false);
			((Component)(object)form_0).Dispose();
			form_0 = null;
		}
	}

	internal Size method_20(DocumentDockContainer documentDockContainer_2)
	{
		Size empty = Size.Empty;
		foreach (DocumentBaseContainer document in documentDockContainer_2.Documents)
		{
			Size size = Size.Empty;
			if (document is DocumentBarContainer)
			{
				size = document.MinimumSize;
			}
			else if (document is DocumentDockContainer)
			{
				size = method_20(document as DocumentDockContainer);
			}
			if (documentDockContainer_2.Orientation == eOrientation.Horizontal)
			{
				empty.Width += size.Width + documentDockContainer_2.SplitterSize;
				if (size.Height < empty.Height || empty.Height == 0)
				{
					empty.Height = size.Height;
				}
			}
			else
			{
				empty.Height += size.Height + documentDockContainer_2.SplitterSize;
				if (size.Width < empty.Width || empty.Width == 0)
				{
					empty.Width = size.Width;
				}
			}
		}
		if (empty.Width > 0 && documentDockContainer_2.Orientation == eOrientation.Horizontal)
		{
			empty.Width += documentDockContainer_2.SplitterSize;
		}
		else if (empty.Height > 0 && documentDockContainer_2.Orientation == eOrientation.Vertical)
		{
			empty.Height += documentDockContainer_2.SplitterSize;
		}
		if (empty.Width == 0)
		{
			empty.Width = 32;
		}
		if (empty.Height == 0)
		{
			empty.Height = 32;
		}
		return empty;
	}

	private Point method_21(int int_1, int int_2)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Invalid comparison between Unknown and I4
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Invalid comparison between Unknown and I4
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Invalid comparison between Unknown and I4
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Invalid comparison between Unknown and I4
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Invalid comparison between Unknown and I4
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Invalid comparison between Unknown and I4
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Invalid comparison between Unknown and I4
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Invalid comparison between Unknown and I4
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Invalid comparison between Unknown and I4
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Invalid comparison between Unknown and I4
		if (documentDockContainer_1 == null)
		{
			return Point.Empty;
		}
		Point result = new Point(int_1, int_2);
		int num = int_1 - point_0.X;
		int num2 = int_2 - point_0.Y;
		if (documentBaseContainer_0 == null)
		{
			if ((int)((Control)dockSite_0).get_Dock() != 3 && (int)((Control)dockSite_0).get_Dock() != 4)
			{
				if ((int)((Control)dockSite_0).get_Dock() != 1 && (int)((Control)dockSite_0).get_Dock() != 2)
				{
					return Point.Empty;
				}
				if ((int)((Control)dockSite_0).get_Dock() == 2)
				{
					num2 *= -1;
				}
				Size size = method_20(documentDockContainer_1);
				if (documentDockContainer_1.DisplayBounds.Height + num2 < size.Height)
				{
					result.Y -= (documentDockContainer_1.DisplayBounds.Height + num2 - size.Height) * (((int)((Control)dockSite_0).get_Dock() != 2) ? 1 : (-1));
				}
				else
				{
					int num3 = method_6();
					int num4 = 32;
					if (dockSite_0.Owner != null)
					{
						num4 = dockSite_0.Owner.MinimumClientSize.Height;
					}
					if (num3 - num2 < num4)
					{
						result.Y -= (num4 - (num3 - num2)) * (((int)((Control)dockSite_0).get_Dock() != 2) ? 1 : (-1));
					}
				}
				return result;
			}
			if ((int)((Control)dockSite_0).get_Dock() == 4)
			{
				num *= -1;
			}
			Size size2 = method_20(documentDockContainer_1);
			if (documentDockContainer_1.DisplayBounds.Width + num < size2.Width)
			{
				result.X -= (documentDockContainer_1.DisplayBounds.Width + num - size2.Width) * (((int)((Control)dockSite_0).get_Dock() != 4) ? 1 : (-1));
			}
			else
			{
				int num5 = method_5();
				int num6 = 32;
				if (dockSite_0.Owner != null)
				{
					num6 = dockSite_0.Owner.MinimumClientSize.Width;
				}
				if (num5 - num < num6)
				{
					result.X -= (num6 - (num5 - num)) * (((int)((Control)dockSite_0).get_Dock() != 4) ? 1 : (-1));
				}
			}
			return result;
		}
		if (documentDockContainer_1.Orientation == eOrientation.Horizontal)
		{
			if (documentBaseContainer_0.DisplayBounds.Width + num >= documentBaseContainer_0.MinimumSize.Width)
			{
				DocumentBaseContainer documentBaseContainer = method_24(documentDockContainer_1, documentDockContainer_1.Documents.IndexOf(documentBaseContainer_0));
				if (documentBaseContainer != null && documentBaseContainer.DisplayBounds.Width - num < documentBaseContainer.MinimumSize.Width)
				{
					result.X += documentBaseContainer.DisplayBounds.Width - num - documentBaseContainer.MinimumSize.Width;
				}
			}
			else
			{
				result.X -= documentBaseContainer_0.DisplayBounds.Width + num - documentBaseContainer_0.MinimumSize.Width;
			}
		}
		else if (documentDockContainer_1.Orientation == eOrientation.Vertical)
		{
			if (documentBaseContainer_0.DisplayBounds.Height + num2 >= documentBaseContainer_0.MinimumSize.Height)
			{
				DocumentBaseContainer documentBaseContainer2 = method_24(documentDockContainer_1, documentDockContainer_1.Documents.IndexOf(documentBaseContainer_0));
				if (documentBaseContainer2 != null && documentBaseContainer2.DisplayBounds.Height - num2 < documentBaseContainer2.MinimumSize.Height)
				{
					result.Y += documentBaseContainer2.DisplayBounds.Height - num2 - documentBaseContainer2.MinimumSize.Height;
				}
			}
			else
			{
				result.Y -= documentBaseContainer_0.DisplayBounds.Height + num2 - documentBaseContainer_0.MinimumSize.Height;
			}
		}
		return result;
	}

	private void method_22(DocumentDockContainer documentDockContainer_2)
	{
		foreach (DocumentBaseContainer document in documentDockContainer_2.Documents)
		{
			document.method_1(Rectangle.Empty);
		}
	}

	private void method_23(int int_1, int int_2)
	{
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Invalid comparison between Unknown and I4
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Invalid comparison between Unknown and I4
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Invalid comparison between Unknown and I4
		//IL_0377: Unknown result type (might be due to invalid IL or missing references)
		//IL_037d: Invalid comparison between Unknown and I4
		if (documentDockContainer_1 == null)
		{
			return;
		}
		Point point = method_21(int_1, int_2);
		int num = point.X - point_0.X;
		int num2 = point.Y - point_0.Y;
		if (documentBaseContainer_0 == null)
		{
			dockSite_0.SuspendLayout();
			if ((int)((Control)dockSite_0).get_Dock() == 3 && num != 0)
			{
				if (documentDockContainer_0.Documents.Count > 0)
				{
					DocumentBaseContainer documentBaseContainer = documentDockContainer_0.Documents[documentDockContainer_0.Documents.Count - 1];
					int num3 = documentBaseContainer.DisplayBounds.Width + num;
					if (num3 > documentBaseContainer.MinimumSize.Width)
					{
						documentBaseContainer.method_1(new Rectangle(documentBaseContainer.DisplayBounds.X, documentBaseContainer.DisplayBounds.Y, num3, documentBaseContainer.DisplayBounds.Height));
					}
					else
					{
						method_22(documentDockContainer_0);
					}
				}
				((Control)dockSite_0).set_Width(((Control)dockSite_0).get_Width() + num);
				if (((Control)dockSite_0).get_Width() <= method_20(documentDockContainer_0).Width)
				{
					method_22(documentDockContainer_0);
				}
			}
			else if ((int)((Control)dockSite_0).get_Dock() == 4 && num != 0)
			{
				if (documentDockContainer_0.Documents.Count > 0)
				{
					DocumentBaseContainer documentBaseContainer2 = documentDockContainer_0.Documents[0];
					int num4 = documentBaseContainer2.DisplayBounds.Width - num;
					if (num4 > documentBaseContainer2.MinimumSize.Width)
					{
						documentBaseContainer2.method_1(new Rectangle(documentBaseContainer2.DisplayBounds.X, documentBaseContainer2.DisplayBounds.Y, num4, documentBaseContainer2.DisplayBounds.Height));
					}
					else
					{
						method_22(documentDockContainer_0);
					}
				}
				((Control)dockSite_0).set_Width(((Control)dockSite_0).get_Width() - num);
				if (((Control)dockSite_0).get_Width() <= method_20(documentDockContainer_0).Width)
				{
					method_22(documentDockContainer_0);
				}
			}
			else if ((int)((Control)dockSite_0).get_Dock() == 1 && num2 != 0)
			{
				if (documentDockContainer_0.Documents.Count > 0)
				{
					DocumentBaseContainer documentBaseContainer3 = documentDockContainer_0.Documents[documentDockContainer_0.Documents.Count - 1];
					int num5 = documentBaseContainer3.DisplayBounds.Height + num2;
					if (num5 > documentBaseContainer3.MinimumSize.Height)
					{
						documentBaseContainer3.method_1(new Rectangle(documentBaseContainer3.DisplayBounds.X, documentBaseContainer3.DisplayBounds.Y, documentBaseContainer3.DisplayBounds.Width, num5));
					}
					else
					{
						method_22(documentDockContainer_0);
					}
				}
				((Control)dockSite_0).set_Height(((Control)dockSite_0).get_Height() + num2);
				if (((Control)dockSite_0).get_Height() <= method_20(documentDockContainer_0).Height)
				{
					method_22(documentDockContainer_0);
				}
			}
			else if ((int)((Control)dockSite_0).get_Dock() == 2 && num2 != 0)
			{
				if (documentDockContainer_0.Documents.Count > 0)
				{
					DocumentBaseContainer documentBaseContainer4 = documentDockContainer_0.Documents[0];
					int num6 = documentBaseContainer4.DisplayBounds.Height - num2;
					if (num6 > documentBaseContainer4.MinimumSize.Height)
					{
						documentBaseContainer4.method_1(new Rectangle(documentBaseContainer4.DisplayBounds.X, documentBaseContainer4.DisplayBounds.Y, documentBaseContainer4.DisplayBounds.Width, num6));
					}
					else
					{
						method_22(documentDockContainer_0);
					}
				}
				((Control)dockSite_0).set_Height(((Control)dockSite_0).get_Height() - num2);
				if (((Control)dockSite_0).get_Height() <= method_20(documentDockContainer_0).Height)
				{
					method_22(documentDockContainer_0);
				}
			}
			dockSite_0.ResumeLayout();
		}
		else if (documentDockContainer_1.Orientation == eOrientation.Horizontal && num != 0)
		{
			documentBaseContainer_0.SetWidth(documentBaseContainer_0.DisplayBounds.Width + num);
		}
		else if (documentDockContainer_1.Orientation == eOrientation.Vertical && num2 != 0)
		{
			documentBaseContainer_0.SetHeight(documentBaseContainer_0.DisplayBounds.Height + num2);
		}
		dockSite_0.RecalcLayout();
	}

	private DocumentBaseContainer method_24(DocumentDockContainer documentDockContainer_2, int int_1)
	{
		int count = documentDockContainer_2.Documents.Count;
		int num = int_1 + 1;
		while (true)
		{
			if (num < count)
			{
				if (documentDockContainer_2.Documents[num].Visible)
				{
					break;
				}
				num++;
				continue;
			}
			return null;
		}
		return documentDockContainer_2.Documents[num];
	}

	public void SetBarWidth(Bar bar, int width)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Invalid comparison between Unknown and I4
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Invalid comparison between Unknown and I4
		if (!(GetDocumentFromBar(bar) is DocumentBarContainer documentBarContainer))
		{
			return;
		}
		if (documentBarContainer.Parent == documentDockContainer_0 && ((int)((Control)dockSite_0).get_Dock() == 3 || (int)((Control)dockSite_0).get_Dock() == 4))
		{
			dockSite_0.SuspendLayout();
			int num = width;
			num = ((documentBarContainer.DisplayBounds.Width != 0) ? (num - documentBarContainer.DisplayBounds.Width) : (num - bar.method_135(eOrientation.Vertical)));
			DockSite dockSite = dockSite_0;
			((Control)dockSite).set_Width(((Control)dockSite).get_Width() + num);
			documentBarContainer.SetWidth(width);
			dockSite_0.ResumeLayout(performLayout: true);
		}
		else if (documentBarContainer.Parent is DocumentDockContainer && ((DocumentDockContainer)documentBarContainer.Parent).Orientation == eOrientation.Vertical)
		{
			((DocumentDockContainer)documentBarContainer.Parent).SetWidth(width);
		}
		else
		{
			if (width < documentBarContainer.MinimumSize.Width)
			{
				width = documentBarContainer.MinimumSize.Width;
			}
			documentBarContainer.SetWidth(width);
		}
		dockSite_0.RecalcLayout();
	}

	public void SetBarHeight(Bar bar, int height)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Invalid comparison between Unknown and I4
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Invalid comparison between Unknown and I4
		if (!(GetDocumentFromBar(bar) is DocumentBarContainer documentBarContainer))
		{
			return;
		}
		if (dockSite_0 != null && ((int)((Control)dockSite_0).get_Dock() == 1 || (int)((Control)dockSite_0).get_Dock() == 2) && documentBarContainer.Parent == documentDockContainer_0)
		{
			dockSite_0.SuspendLayout();
			int num = height;
			num = ((documentBarContainer.DisplayBounds.Height != 0) ? (num - documentBarContainer.DisplayBounds.Height) : (num - bar.method_135(eOrientation.Vertical)));
			DockSite dockSite = dockSite_0;
			((Control)dockSite).set_Height(((Control)dockSite).get_Height() + num);
			documentBarContainer.SetHeight(height);
			dockSite_0.ResumeLayout(performLayout: true);
		}
		else if (documentBarContainer.Parent is DocumentDockContainer && ((DocumentDockContainer)documentBarContainer.Parent).Orientation == eOrientation.Horizontal)
		{
			((DocumentDockContainer)documentBarContainer.Parent).SetHeight(height);
		}
		else
		{
			if (height < documentBarContainer.MinimumSize.Height)
			{
				height = documentBarContainer.MinimumSize.Height;
			}
			documentBarContainer.SetHeight(height);
		}
		dockSite_0.RecalcLayout();
	}

	internal void method_25(XmlElement xmlElement_0)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Invalid comparison between Unknown and I4
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Invalid comparison between Unknown and I4
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Invalid comparison between Unknown and I4
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		XmlElement xmlElement = null;
		if ((int)((Control)dockSite_0).get_Dock() == 5)
		{
			xmlElement = xmlElement_0.OwnerDocument.CreateElement(Class171.string_0);
		}
		else
		{
			xmlElement = xmlElement_0.OwnerDocument.CreateElement(Class171.string_6);
			xmlElement.SetAttribute(Class171.string_8, XmlConvert.ToString(((int)((Control)dockSite_0).get_Dock() == 3 || (int)((Control)dockSite_0).get_Dock() == 4) ? ((Control)dockSite_0).get_Width() : ((Control)dockSite_0).get_Height()));
			xmlElement.SetAttribute(Class171.string_7, Enum.GetName(typeof(DockStyle), ((Control)dockSite_0).get_Dock()));
		}
		xmlElement_0.AppendChild(xmlElement);
		method_27(xmlElement, documentDockContainer_0, bool_2: true);
	}

	internal void method_26(XmlElement xmlElement_0)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Invalid comparison between Unknown and I4
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Invalid comparison between Unknown and I4
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Invalid comparison between Unknown and I4
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		XmlElement xmlElement = null;
		if ((int)((Control)dockSite_0).get_Dock() == 5)
		{
			xmlElement = xmlElement_0.OwnerDocument.CreateElement(Class171.string_0);
		}
		else
		{
			xmlElement = xmlElement_0.OwnerDocument.CreateElement(Class171.string_6);
			xmlElement.SetAttribute(Class171.string_8, XmlConvert.ToString(((int)((Control)dockSite_0).get_Dock() == 3 || (int)((Control)dockSite_0).get_Dock() == 4) ? ((Control)dockSite_0).get_Width() : ((Control)dockSite_0).get_Height()));
			xmlElement.SetAttribute(Class171.string_7, Enum.GetName(typeof(DockStyle), ((Control)dockSite_0).get_Dock()));
		}
		xmlElement_0.AppendChild(xmlElement);
		method_27(xmlElement, documentDockContainer_0, bool_2: false);
	}

	private void method_27(XmlElement xmlElement_0, DocumentDockContainer documentDockContainer_2, bool bool_2)
	{
		if (documentDockContainer_2.Documents.Count == 0)
		{
			return;
		}
		XmlElement xmlElement = null;
		xmlElement = xmlElement_0.OwnerDocument.CreateElement(Class171.string_1);
		xmlElement_0.AppendChild(xmlElement);
		xmlElement.SetAttribute(Class171.string_3, XmlConvert.ToString((int)documentDockContainer_2.Orientation));
		xmlElement.SetAttribute(Class171.string_4, documentDockContainer_2.LayoutBounds.Width.ToString());
		xmlElement.SetAttribute(Class171.string_5, documentDockContainer_2.LayoutBounds.Height.ToString());
		foreach (DocumentBaseContainer document in documentDockContainer_2.Documents)
		{
			if (document is DocumentDockContainer)
			{
				method_27(xmlElement, (DocumentDockContainer)document, bool_2);
			}
			else if (document is DocumentBarContainer)
			{
				method_28(xmlElement, (DocumentBarContainer)document, bool_2);
			}
		}
	}

	private void method_28(XmlElement xmlElement_0, DocumentBarContainer documentBarContainer_0, bool bool_2)
	{
		if (documentBarContainer_0.Bar != null && documentBarContainer_0.Bar.SaveLayoutChanges)
		{
			XmlElement xmlElement = xmlElement_0.OwnerDocument.CreateElement(Class171.string_2);
			xmlElement_0.AppendChild(xmlElement);
			xmlElement.SetAttribute(Class171.string_4, documentBarContainer_0.LayoutBounds.Width.ToString());
			xmlElement.SetAttribute(Class171.string_5, documentBarContainer_0.LayoutBounds.Height.ToString());
			XmlElement xmlElement2 = xmlElement_0.OwnerDocument.CreateElement(Class172.string_0);
			xmlElement.AppendChild(xmlElement2);
			if (bool_2)
			{
				documentBarContainer_0.Bar.method_78(xmlElement2);
			}
			else
			{
				documentBarContainer_0.Bar.method_85(xmlElement2);
			}
		}
	}

	internal void method_29(XmlElement xmlElement_0)
	{
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Invalid comparison between Unknown and I4
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Invalid comparison between Unknown and I4
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Invalid comparison between Unknown and I4
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Invalid comparison between Unknown and I4
		if ((xmlElement_0.Name != Class171.string_0 && xmlElement_0.Name != Class171.string_6) || bool_1)
		{
			return;
		}
		bool_1 = true;
		ItemSerializationContext itemSerializationContext = new ItemSerializationContext();
		try
		{
			foreach (XmlElement childNode in xmlElement_0.ChildNodes)
			{
				if (childNode.Name == Class171.string_1)
				{
					itemSerializationContext.ItemXmlElement = childNode;
					method_31(itemSerializationContext, documentDockContainer_0, bool_2: false);
					break;
				}
			}
		}
		finally
		{
			bool_1 = false;
		}
		if (xmlElement_0.Name == Class171.string_6)
		{
			if ((int)((Control)dockSite_0).get_Dock() != 3 && (int)((Control)dockSite_0).get_Dock() != 4)
			{
				if ((int)((Control)dockSite_0).get_Dock() == 1 || (int)((Control)dockSite_0).get_Dock() == 2)
				{
					((Control)dockSite_0).set_Height(XmlConvert.ToInt32(xmlElement_0.GetAttribute(Class171.string_8)));
				}
			}
			else
			{
				((Control)dockSite_0).set_Width(XmlConvert.ToInt32(xmlElement_0.GetAttribute(Class171.string_8)));
			}
		}
		dockSite_0.RecalcLayout();
	}

	internal void method_30(ItemSerializationContext itemSerializationContext_0)
	{
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Invalid comparison between Unknown and I4
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Invalid comparison between Unknown and I4
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Invalid comparison between Unknown and I4
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Invalid comparison between Unknown and I4
		XmlElement itemXmlElement = itemSerializationContext_0.ItemXmlElement;
		if ((itemXmlElement.Name != Class171.string_0 && itemXmlElement.Name != Class171.string_6) || bool_1)
		{
			return;
		}
		bool_1 = true;
		try
		{
			foreach (XmlElement childNode in itemXmlElement.ChildNodes)
			{
				if (childNode.Name == Class171.string_1)
				{
					itemSerializationContext_0.ItemXmlElement = childNode;
					method_31(itemSerializationContext_0, documentDockContainer_0, bool_2: true);
					break;
				}
			}
			if (itemXmlElement.HasAttribute(Class171.string_8))
			{
				if ((int)((Control)dockSite_0).get_Dock() != 3 && (int)((Control)dockSite_0).get_Dock() != 4)
				{
					if ((int)((Control)dockSite_0).get_Dock() == 1 || (int)((Control)dockSite_0).get_Dock() == 2)
					{
						((Control)dockSite_0).set_Height(XmlConvert.ToInt32(itemXmlElement.GetAttribute(Class171.string_8)));
					}
				}
				else
				{
					((Control)dockSite_0).set_Width(XmlConvert.ToInt32(itemXmlElement.GetAttribute(Class171.string_8)));
				}
			}
		}
		finally
		{
			bool_1 = false;
		}
		dockSite_0.RecalcLayout();
	}

	private void method_31(ItemSerializationContext itemSerializationContext_0, DocumentDockContainer documentDockContainer_2, bool bool_2)
	{
		XmlElement itemXmlElement = itemSerializationContext_0.ItemXmlElement;
		if (itemXmlElement.Name != Class171.string_1)
		{
			return;
		}
		documentDockContainer_2.Documents.Clear();
		documentDockContainer_2.Orientation = (eOrientation)XmlConvert.ToInt32(itemXmlElement.GetAttribute(Class171.string_3));
		if (itemXmlElement.HasAttribute(Class171.string_4) && itemXmlElement.HasAttribute(Class171.string_5))
		{
			documentDockContainer_2.method_1(new Rectangle(0, 0, XmlConvert.ToInt32(itemXmlElement.GetAttribute(Class171.string_4)), XmlConvert.ToInt32(itemXmlElement.GetAttribute(Class171.string_5))));
		}
		foreach (XmlElement childNode in itemXmlElement.ChildNodes)
		{
			bool flag = true;
			DocumentBaseContainer documentBaseContainer = Class171.smethod_0(childNode.Name);
			itemSerializationContext_0.ItemXmlElement = childNode;
			if (documentBaseContainer is DocumentDockContainer)
			{
				method_31(itemSerializationContext_0, (DocumentDockContainer)documentBaseContainer, bool_2);
			}
			else if (documentBaseContainer is DocumentBarContainer)
			{
				flag = method_32(itemSerializationContext_0, (DocumentBarContainer)documentBaseContainer, bool_2);
			}
			if (flag)
			{
				documentDockContainer_2.Documents.Add(documentBaseContainer);
			}
		}
	}

	private bool method_32(ItemSerializationContext itemSerializationContext_0, DocumentBarContainer documentBarContainer_0, bool bool_2)
	{
		XmlElement itemXmlElement = itemSerializationContext_0.ItemXmlElement;
		if (itemXmlElement.Name != Class171.string_2)
		{
			return false;
		}
		documentBarContainer_0.method_1(new Rectangle(0, 0, XmlConvert.ToInt32(itemXmlElement.GetAttribute(Class171.string_4)), XmlConvert.ToInt32(itemXmlElement.GetAttribute(Class171.string_5))));
		foreach (XmlElement childNode in itemXmlElement.ChildNodes)
		{
			if (!(childNode.Name == Class172.string_0))
			{
				continue;
			}
			documentBarContainer_0.Bar = dockSite_0.Owner.Bars[childNode.GetAttribute(Class172.string_1)];
			if (!bool_2 && (documentBarContainer_0.Bar != null || !childNode.HasAttribute(Class172.string_2) || !XmlConvert.ToBoolean(childNode.GetAttribute(Class172.string_2))))
			{
				if (documentBarContainer_0.Bar != null)
				{
					documentBarContainer_0.Bar.method_86(childNode);
					if (!documentBarContainer_0.Bar.Boolean_8)
					{
						if (documentBarContainer_0.LayoutBounds.Height > 0 && (documentBarContainer_0.Bar.DockSide == eDockSide.Top || documentBarContainer_0.Bar.DockSide == eDockSide.Bottom))
						{
							((Control)documentBarContainer_0.Bar).set_Height(documentBarContainer_0.LayoutBounds.Height);
						}
						else if (documentBarContainer_0.LayoutBounds.Width > 0 && (documentBarContainer_0.Bar.DockSide == eDockSide.Left || documentBarContainer_0.Bar.DockSide == eDockSide.Right))
						{
							((Control)documentBarContainer_0.Bar).set_Width(documentBarContainer_0.LayoutBounds.Width);
						}
					}
					break;
				}
				return false;
			}
			documentBarContainer_0.Bar = new Bar();
			dockSite_0.Owner.Bars.Add(documentBarContainer_0.Bar);
			if (bool_2)
			{
				documentBarContainer_0.Bar.method_81(childNode, itemSerializationContext_0);
			}
			else
			{
				documentBarContainer_0.Bar.method_86(childNode);
			}
			if (documentBarContainer_0.Bar.Items.Count == 0 && !bool_2)
			{
				dockSite_0.Owner.Bars.Remove(documentBarContainer_0.Bar);
				return false;
			}
			return true;
		}
		return true;
	}
}
