
using System;
using Tizen;
using Tizen.Applications;
using Tizen.NUI;
using Tizen.NUI.BaseComponents;
// using Tizen.Data.Tdbc;
// using Tizen.Data.Tdao;
// using Tizen.Data.Tdao.Generated;
using System.IO;
using Tizen.NUI.Components;

namespace Tizen.NUI.Samples
{
    public class AccessibilityManagerSample : IExample
    {
        // private UserDaoImpl _dao;
        // private IConnection _conn;
        private Window _window;
        private View _mainView;
        private Navigator _navigator;
        private View _tableView;
        private View _buttonView;
        private View _table;
        int _idx = 0;

        private const String LOGTAG = "TdaoSample";

        public void Activate()
        {
            Initialize();
        }

        private TextLabel CreateBlock(string content)
        {
            TextLabel block = new TextLabel(content);
            block.BackgroundColor = Color.White;
            block.HorizontalAlignment = HorizontalAlignment.Center;
            block.CellHorizontalAlignment = HorizontalAlignmentType.Center;
            return block;
        }

        private Button CreateButton(string content)
        {
            var button = new Button
            {
                Text = content,
                WidthResizePolicy = ResizePolicyType.FillToParent,
                HeightResizePolicy = ResizePolicyType.FillToParent,
                SizeHeight = 100f,
                TextColorSelector = new ColorSelector
                {
                    Normal = new Color(0, 0, 0, 1),
                    Pressed = new Color(0, 0, 0, 0.7f),
                    Selected = Color.Blue,
                    Disabled = new Color(0, 0, 0, 0.4f)
                }
            };

            return button;
        }

        private View CreateTextField(string title)
        {
            var field = new View()
            {
                Layout = new LinearLayout()
                {
                    LinearOrientation = LinearLayout.Orientation.Horizontal,
                },
                WidthResizePolicy = ResizePolicyType.FillToParent,
                Padding = 10,
            };
            field.Add(new TextLabel() { Text = title, SizeWidth = 100 });
            field.Add(new TextField()
            {
                WidthSpecification = LayoutParamPolicies.MatchParent,
                BackgroundColor = Color.White,
                WidthResizePolicy = ResizePolicyType.FillToParent,
                BorderlineColor = Color.Black,
                BorderlineWidth = 1,
                EnableCursorBlink = true,
                SizeHeight = 40,
                VerticalAlignment = VerticalAlignment.Center,
                Padding = 10,
            });

            return field;
        }

        void TableUpdate()
        {
            if (_table)
            {
                _tableView.Remove(_table);
            }
            // LiveEntityList<UserEntity> usersEntity = _dao.FindAll();
            // System.Collections.Generic.List<UserEntity> users;
            // if (usersEntity == null)
            //     users = new System.Collections.Generic.List<UserEntity>();
            // else
            //     users = usersEntity.Get();

            TableView tableView = new TableView((uint)5, 5)
            {
                WidthResizePolicy = ResizePolicyType.FillToParent,
                SizeHeight = 100 * (4 + 1),
            };

            TextLabel id = CreateBlock("ID");
            tableView.AddChild(id, new TableView.CellPosition(0, 0));

            TextLabel name = CreateBlock("Name");
            tableView.AddChild(name, new TableView.CellPosition(0, 1));

            TextLabel age = CreateBlock("Age");
            tableView.AddChild(age, new TableView.CellPosition(0, 2));

            TextLabel height = CreateBlock("height");
            tableView.AddChild(height, new TableView.CellPosition(0, 3));

            TextLabel weight = CreateBlock("Weight");
            tableView.AddChild(weight, new TableView.CellPosition(0, 4));

            _idx = -1;
            for (uint row = 0; row < 4; ++row)
            {
                id = CreateBlock("ID");
                tableView.AddChild(id, new TableView.CellPosition(row + 1, 0));

                name = CreateBlock("Name");
                tableView.AddChild(name, new TableView.CellPosition(row + 1, 1));

                age = CreateBlock("Age");
                tableView.AddChild(age, new TableView.CellPosition(row + 1, 2));

                height = CreateBlock("height");
                tableView.AddChild(height, new TableView.CellPosition(row + 1, 3));

                weight = CreateBlock("Weight");
                tableView.AddChild(weight, new TableView.CellPosition(row + 1, 4));
            }

            tableView.CellHorizontalAlignment = HorizontalAlignmentType.Center;
            _table = tableView;
            _tableView.Add(_table);
        }

        void Initialize()
        {
            _window = Window.Instance;
            _navigator = _window.GetDefaultNavigator();
            _navigator.CellHorizontalAlignment = HorizontalAlignmentType.Center;
            _navigator.WidthResizePolicy = ResizePolicyType.FillToParent;
            _navigator.HeightResizePolicy = ResizePolicyType.FillToParent;
            _tableView = new View()
            {
                CellHorizontalAlignment = HorizontalAlignmentType.Center,
                WidthResizePolicy = ResizePolicyType.FillToParent,
                HeightResizePolicy = ResizePolicyType.FitToChildren,
            };
            _buttonView = new View()
            {
                Layout = new LinearLayout()
                {
                    LinearOrientation = LinearLayout.Orientation.Horizontal,
                    HorizontalAlignment = HorizontalAlignment.Center,
                    CellPadding = new Size2D(100, 200),
                },
                CellHorizontalAlignment = HorizontalAlignmentType.Center,
                WidthResizePolicy = ResizePolicyType.FillToParent,
                Padding = 50,
            };
            _mainView = new View()
            {
                Layout = new FlexLayout()
                {
                    Direction = FlexLayout.FlexDirection.Column,
                    Justification = FlexLayout.FlexJustification.SpaceBetween,
                    Alignment = FlexLayout.AlignmentType.Stretch,
                },
                CellHorizontalAlignment = HorizontalAlignmentType.Center,
                WidthResizePolicy = ResizePolicyType.FillToParent,
                HeightSpecification = LayoutParamPolicies.MatchParent,
            };

            try
            {
                // DriverManager.RegisterDriver("Tizen.Data.Tdbc.Driver.Sqlite");
                // _conn = DriverManager.GetConnection(new Uri("tdbc://localhost/" + DirectoryInfo.Data + "User.db"));
                // _dao = new UserDaoImpl(_conn);
                // _dao.CreateAllTables();
                TableUpdate();
                Page page = new ContentPage()
                {
                    AppBar = new AppBar()
                    {
                        Name = "Tdao sample app"
                    },
                    Content = _mainView,
                    HeightResizePolicy = ResizePolicyType.FillToParent,
                };
                _navigator.Push(page);

                Button add_button = CreateButton("Add");
                add_button.Clicked += (s, e) =>
                {
                    var button = new Button()
                    {
                        Text = "OK",
                    };

                    var add_user_field = new View()
                    {
                        Layout = new LinearLayout()
                        {
                            LinearOrientation = LinearLayout.Orientation.Vertical,
                            HorizontalAlignment = HorizontalAlignment.Center,
                            VerticalAlignment = VerticalAlignment.Center,
                        },
                        WidthResizePolicy = ResizePolicyType.FillToParent,
                        Padding = 10,
                    };

                    var name_field = CreateTextField("Name");
                    var age_field = CreateTextField("Age");
                    var height_field = CreateTextField("Height");
                    var weight_field = CreateTextField("Weight");

                    add_user_field.Add(name_field);
                    add_user_field.Add(age_field);
                    add_user_field.Add(height_field);
                    add_user_field.Add(weight_field);
                    add_user_field.Add(button);
                    button.Clicked += (object sender, ClickedEventArgs args) =>
                    {
                        int pId = _idx;
                        try
                        {
                            // UserEntity new_user = new UserEntity()
                            // {
                            //     Id = (++_idx),
                            //     Name = (name_field.GetChildAt(1) as TextField).Text,
                            //     Age = Int32.Parse((age_field.GetChildAt(1) as TextField).Text),
                            //     Height = Double.Parse((height_field.GetChildAt(1) as TextField).Text),
                            //     Weight = Double.Parse((weight_field.GetChildAt(1) as TextField).Text),
                            // };

                            // _dao.Insert(new_user);
                            TableUpdate();
                        }
                        catch (Exception ex)
                        {
                            _idx = pId;
                            Log.Error(LOGTAG, ex.Message);
                        }

                        _window.GetDefaultNavigator().Pop();
                    };
                    DialogPage.ShowAlertDialog("Add user", "Please insert user info", add_user_field);
                };

                Button delete_button = CreateButton("Delete");
                delete_button.Clicked += (s, e) =>
                {
                    var button = new Button()
                    {
                        Text = "OK",
                    };

                    var delete_user_field = new View()
                    {
                        Layout = new LinearLayout()
                        {
                            LinearOrientation = LinearLayout.Orientation.Vertical,
                            HorizontalAlignment = HorizontalAlignment.Center,
                            VerticalAlignment = VerticalAlignment.Center,
                        },
                        WidthResizePolicy = ResizePolicyType.FillToParent,
                        Padding = 10,
                    };

                    var id_field = CreateTextField("ID");

                    delete_user_field.Add(id_field);
                    delete_user_field.Add(button);
                    button.Clicked += (object sender, ClickedEventArgs args) =>
                    {
                        try
                        {
                            // UserEntity delete_user = new UserEntity()
                            // {
                            //     Id = Int32.Parse((id_field.GetChildAt(1) as TextField).Text),
                            // };

                            // _dao.Delete(delete_user);
                            TableUpdate();
                        }
                        catch (Exception ex)
                        {
                            Log.Error(LOGTAG, ex.Message);
                        }
                        _window.GetDefaultNavigator().Pop();
                    };
                    DialogPage.ShowAlertDialog("Delete user", "Please insert delete user id", delete_user_field);
                };

                _buttonView.Add(add_button);
                _buttonView.Add(delete_button);

                _mainView.Add(_tableView);
                _mainView.Add(_buttonView);
                _window.KeyEvent += OnKeyEvent;

                _window.AddAvailableOrientation(Window.WindowOrientation.Portrait);
                _window.AddAvailableOrientation(Window.WindowOrientation.Landscape);
                _window.AddAvailableOrientation(Window.WindowOrientation.PortraitInverse);
                _window.AddAvailableOrientation(Window.WindowOrientation.LandscapeInverse);
            }

            catch (Exception e)
            {
                Log.Error(LOGTAG, e.Message);
                Log.Error(LOGTAG, e.StackTrace);
                TextLabel label = new TextLabel(e.Message);
                label.TextColor = Color.Black;
                _window.Add(label);
            }

        }

        public void OnKeyEvent(object sender, Window.KeyEventArgs e)
        {
            if (e.Key.State == Key.StateType.Down && (e.Key.KeyPressedName == "XF86Back" || e.Key.KeyPressedName == "Escape"))
            {
                //Exit();
            }
        }


        public void Deactivate()
        {
        }
    }
}
