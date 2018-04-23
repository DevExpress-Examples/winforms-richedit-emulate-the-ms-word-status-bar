using DevExpress.XtraRichEdit.API.Layout;
using DevExpress.XtraRichEdit.API.Native;
using DevExpress.XtraRichEdit.Layout;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;

namespace WindowsFormsApplication1
{
    public class StaticsticsVisitor : IDocumentVisitor
    {
        readonly StringBuilder buffer;

        public StaticsticsVisitor()
        {
            WordCount = 0;
            this.buffer = new StringBuilder();
        }

        public virtual void Visit(DocumentText text)
        {
            Buffer.Append(text.Text);
        }

        public virtual void Visit(DocumentParagraphEnd paragraphEnd)
        {
            FinishParagraph();
        }

        void FinishParagraph()
        {
            string text = Buffer.ToString();
            this.WordCount += text.Split(new char[] { ' ', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
            Buffer.Length = 0;
        }

        public virtual void Visit(DocumentTableCellBorder cellBorder) { }
        public virtual void Visit(DocumentSectionStart sectionStart) { }
        public virtual void Visit(DocumentFieldCodeStart fieldCodeStart) { }
        public virtual void Visit(DocumentFieldCodeEnd fieldCodeEnd) { }
        public virtual void Visit(DocumentFieldResultEnd fieldResultEnd) { }
        public virtual void Visit(DocumentBookmarkStart bookmarkStart) { }
        public virtual void Visit(DocumentBookmarkEnd bookmarkEnd) { }
        public virtual void Visit(DocumentCommentStart commentStart) { }
        public virtual void Visit(DocumentSectionEnd sectionEnd) { }
        public virtual void Visit(DocumentCommentEnd commentEnd) { }
        public virtual void Visit(DocumentRangePermissionStart rangePermissionStart) { }
        public virtual void Visit(DocumentRangePermissionEnd rangePermissionEnd) { }
        public virtual void Visit(DocumentTextBox textBox) { }
        public virtual void Visit(DocumentParagraphStart paragraphStart) { }
        public virtual void Visit(DocumentInlinePicture inlinePicture) { }
        public virtual void Visit(DocumentPicture picture) { }
        public virtual void Visit(DocumentHyperlinkStart hyperlinkStart) { }
        public virtual void Visit(DocumentHyperlinkEnd hyperlinkEnd) { }

        public int WordCount { get; private set; }
        protected StringBuilder Buffer { get { return buffer; } }
    }

    public class CustomLayoutVisitor : LayoutVisitor
    {
        Document document;

        public CustomLayoutVisitor(Document doc)
        {
            this.document = doc;
            RowIndex = 0;
            ColIndex = 0;
            IsFound = false;
        }

        protected override void VisitRow(LayoutRow row)
        {
            if (!IsFound)
            {
                RowIndex++;
                if (row.Range.Contains(document.CaretPosition.ToInt()))
                {
                    IsFound = true;
                    ColIndex = document.CaretPosition.ToInt() - row.Range.Start;
                }
            }
            base.VisitRow(row);
        }

        public void Reset()
        {
            RowIndex = 0;
            ColIndex = 0;
        }

        public int ColIndex { get; private set; }
        public int RowIndex { get; private set; }
        public bool IsFound { get; private set; }
    }
}
