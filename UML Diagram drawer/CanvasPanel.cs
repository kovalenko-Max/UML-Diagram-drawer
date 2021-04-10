using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UML_Diagram_drawer
{
    class CanvasPanel : Panel
    {
        private List<ISelectable> _selectedObjects;
        private List<ISelectable> _objects;
        private ISelectable _selectObject;
        private ISelectable _drawingObject;
        private Graphics _graphics;
        private Point _lastMousePosition = Point.Empty;
        private bool _isDraw;
        private bool _isSelect;

        public CanvasPanel()
        {
            Dock = DockStyle.Fill;
            DoubleBuffered = true;
            _objects = new List<ISelectable>();
            _selectedObjects = new List<ISelectable>();
        }

        public void CreateObject(FormMain.ObjectType type)
        {
            _isDraw = true;
            switch (type)
            {
                case FormMain.ObjectType.ArrowAggregation:
                    _drawingObject = new ArrowAggregation(_graphics, Color.Black);
                    break;
                case FormMain.ObjectType.ArrowAssociation:
                    _drawingObject = new ArrowAssociation(_graphics, Color.Black);
                    break;
                case FormMain.ObjectType.ArrowComposition:
                    _drawingObject = new ArrowComposition(_graphics, Color.Black);
                    break;
                case FormMain.ObjectType.ArrowRealization:
                    _drawingObject = new ArrowRealization(_graphics, Color.Black);
                    break;
                case FormMain.ObjectType.ArrowSuccession:
                    _drawingObject = new ArrowSuccession(_graphics, Color.Black);
                    break;
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            if (e.Button == MouseButtons.Left)
            {
                if (_isDraw)
                {
                    _selectedObjects.Clear();
                    _isSelect = false;

                    if (_drawingObject is AbstactArrow)
                    {
                        AbstactArrow tempObj = (AbstactArrow)_drawingObject;
                        tempObj.From = e.Location;
                        _drawingObject = tempObj;
                    }
                }
                else if (!_isDraw)
                {
                    bool isResetAllSelect = true;
                    foreach (var drawObject in _objects)
                    {
                        if (!drawObject.IsSelected && drawObject.Select(e.Location))
                        {
                            isResetAllSelect = false;
                            _isSelect = true;
                            _selectObject = drawObject;
                            _selectedObjects.Add(drawObject);
                            break;
                        }
                        if (drawObject.Select(e.Location))
                        {
                            if (_selectObject == drawObject)
                            {
                                isResetAllSelect = false;
                            }
                        }
                    }

                    if (isResetAllSelect)
                    {
                        foreach (var selectObject in _selectedObjects)
                        {
                            selectObject.RemoveSelect();
                        }
                        _selectedObjects.Clear();
                        _selectObject = null;
                        _isSelect = false;
                    }
                }
            }

            Invalidate();
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (e.Button == MouseButtons.Left)
            {
                if (_isDraw)
                {
                    if (_drawingObject is AbstactArrow)
                    {
                        AbstactArrow tempObj = (AbstactArrow)_drawingObject;
                        tempObj.To = e.Location;
                        tempObj.Graphics = _graphics;

                        _drawingObject = tempObj;
                    }
                }
                else if (!_isDraw && _isSelect)
                {
                    bool isMove = false;
                    foreach (var selectObject in _selectedObjects)
                    {
                        if (selectObject.Select(e.Location))
                        {
                            isMove = true;
                            break;
                        }
                    }

                    if (isMove)
                    {
                        foreach (var selectObject in _selectedObjects)
                        {
                            selectObject.Move(e.X - _lastMousePosition.X, e.Y - _lastMousePosition.Y);
                            _lastMousePosition = e.Location;
                        }
                    }
                }

            }

            _lastMousePosition = e.Location;
            Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            if (e.Button == MouseButtons.Left)
            {
                if (_isDraw)
                {
                    if (_drawingObject is AbstactArrow)
                    {
                        AbstactArrow tempObj = (AbstactArrow)_drawingObject;
                        tempObj.To = e.Location;
                        tempObj.Graphics = _graphics;

                        _drawingObject = tempObj;
                        _objects.Add(_drawingObject);
                    }

                    _isDraw = false;
                }
                else if (!_isDraw)
                {
                    foreach (var drawObject in _objects)
                    {
                        if (drawObject.IsSelected && drawObject.Select(e.Location))
                        {
                            if (_selectObject != drawObject)
                            {
                                drawObject.RemoveSelect();
                                _selectedObjects.Remove(drawObject);

                                if (_selectedObjects.Count == 0)
                                {
                                    _isSelect = false;
                                }
                            }
                        }
                    }
                }
            }

            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            _graphics = e.Graphics;
            foreach (var drawingObject in _objects)
            {
                drawingObject.Graphics = _graphics;
                drawingObject.Draw();
            }

            foreach (var selectObject in _selectedObjects)
            {
                selectObject.Graphics = _graphics;
                selectObject.Draw();
            }

            if (_drawingObject != null)
            {
                _drawingObject.Graphics = _graphics;
                _drawingObject.Draw();
            }
        }
    }
}
